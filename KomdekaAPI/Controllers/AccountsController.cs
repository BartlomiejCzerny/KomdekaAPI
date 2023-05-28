using AutoMapper;
using EmailService;
using KomdekaAPI.Entities.DataTransferObjects;
using KomdekaAPI.Entities.Models;
using KomdekaAPI.JwtFeatures;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomdekaAPI.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly JwtHandler _jwtHandler;
        private readonly IEmailSender _emailSender;

        public AccountsController(UserManager<User> userManager, IMapper mapper, JwtHandler jwtHandler, IEmailSender emailSender)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtHandler = jwtHandler;
            _emailSender = emailSender;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> Register([FromBody] UserForRegistrationDto userForRegistration)
        {
            if (userForRegistration == null || !ModelState.IsValid)
                return BadRequest();

            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                return BadRequest(new RegistrationResponseDto { Errors = errors });
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var param = new Dictionary<string, string>
            {
                { "token", token },
                { "email", user.Email }
            };

            var activationLink = QueryHelpers.AddQueryString(userForRegistration.ClientURI, param);

            var subject = "Aktywacja konta użytkownika w systemie Komdeka";
            var greeting = $"Witaj { user.FirstName },<br><br>";
            var body = "Twoje konto użytkownika zostało zarejestrowane w systemie Komdeka.<br>" +
                       $"Kliknij poniższy link w celu aktywacji konta:<br>{ activationLink }<br><br>" +
                       "Jeżeli rejestracja konta nie została przeprowadzona przez Ciebie, zignoruj tę wiadomość.<br><br>";
            var signature = "Pozdrawiam<br>Bartłomiej Czerny<br>Programista/Administrator systemu Komdeka";

            var message = new Message(new string[] { user.Email }, subject, greeting + body + signature);
            await _emailSender.SendEmailAsync(message);

            await _userManager.AddToRoleAsync(user, "Pracownik");

            return StatusCode(201);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            var user = await _userManager.FindByNameAsync(userForAuthentication.Email);

            if (user == null)
                return BadRequest("Konto użytkownika o podanym adresie e-mail nie istnieje.");

            if (!await _userManager.IsEmailConfirmedAsync(user))
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Nie potwierdzono adresu e-mail." });

            if (!await _userManager.CheckPasswordAsync(user, userForAuthentication.Password))
            {
                await _userManager.AccessFailedAsync(user);

                if (await _userManager.IsLockedOutAsync(user))
                {
                    var subject = "Blokada konta użytkownika w systemie Komdeka";
                    var greeting = $"Witaj { user.FirstName },<br><br>";
                    var body = "Twoje konto użytkownika w systemie Komdeka zostało zablokowane.<br>" +
                               $"Aby odzyskać dostęp do konta kliknij poniższy link, a następnie postępuj zgodnie z instrukcjami systemu Komdeka:<br>{ userForAuthentication.ClientURI }<br><br>" +
                               "Pamiętaj, że trzykrotne wprowadzenie nieprawidłowego hasła powoduje blokadę konta.<br><br>";
                    var signature = "Pozdrawiam<br>Bartłomiej Czerny<br>Programista/Administrator systemu Komdeka";

                    var message = new Message(new string[] { userForAuthentication.Email }, subject, greeting + body + signature);
                    await _emailSender.SendEmailAsync(message);

                    return Unauthorized(new AuthResponseDto { ErrorMessage = "Konto użytkownika zostało zablokowane." });
                }

                return Unauthorized(new AuthResponseDto { ErrorMessage = "Wprowadzono nieprawidłowe hasło." });
            }

            if (await _userManager.GetTwoFactorEnabledAsync(user))
                return await GenerateOTPFor2StepVerification(user);

            var token = await _jwtHandler.GenerateToken(user);

            await _userManager.ResetAccessFailedCountAsync(user);

            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }

        private async Task<IActionResult> GenerateOTPFor2StepVerification(User user)
        {
            var providers = await _userManager.GetValidTwoFactorProvidersAsync(user);
            if (!providers.Contains("Email"))
            {
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Nieprawidłowy dostawca weryfikacji dwuetapowej." });
            }

            var token = await _userManager.GenerateTwoFactorTokenAsync(user, "Email");

            var subject = "Logowanie do systemu Komdeka";
            var greeting = $"Witaj { user.FirstName },<br><br>";
            var body = $"zaloguj się do systemu Komdeka wprowadzając poniższy kod weryfikacyjny:<br><strong>{ token }</strong><br><br>" +
                       "Jeżeli logowanie nie zostało przeprowadzone przez Ciebie, zignoruj tę wiadomość.<br><br>";
            var signature = "Pozdrawiam<br>Bartłomiej Czerny<br>Programista/Administrator systemu Komdeka";

            var message = new Message(new string[] { user.Email }, subject, greeting + body + signature);
            await _emailSender.SendEmailAsync(message);

            return Ok(new AuthResponseDto { Is2StepVerificationRequired = true, Provider = "Email" });
        }

        [HttpPost("TwoStepVerification")]
        public async Task<IActionResult> TwoStepVerification([FromBody] TwoFactorDto twoFactorDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByEmailAsync(twoFactorDto.Email);
            if (user == null)
                return BadRequest("Invalid Request");

            var validVerification = await _userManager.VerifyTwoFactorTokenAsync(user, twoFactorDto.Provider, twoFactorDto.Token);
            if (!validVerification)
                return BadRequest("Wprowadzono nieprawidłowy kod weryfikacyjny.");

            var token = await _jwtHandler.GenerateToken(user);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }

        [HttpGet("AccountActivation")]
        public async Task<IActionResult> AccountActivation([FromQuery] string email, [FromQuery] string token)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return BadRequest("Konto użytkownika nie istnieje.");

            var confirmResult = await _userManager.ConfirmEmailAsync(user, token);
            if (!confirmResult.Succeeded)
                return BadRequest("Nie aktywowano konta użytkownika, gdyż został użyty nieprawidłowy link aktywacyjny.");

            await _userManager.SetTwoFactorEnabledAsync(user, true);

            return Ok();
        }

        [HttpPost("AccountRecovery")]
        public async Task<IActionResult> AccountRecovery([FromBody] AccountRecoveryDto accountRecoveryDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByEmailAsync(accountRecoveryDto.Email);
            if (user == null)
                return BadRequest("Konto użytkownika o podanym adresie e-mail nie istnieje.");

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var param = new Dictionary<string, string>
            {
                { "token", token },
                { "email", accountRecoveryDto.Email }
            };

            var passwordResetToken = QueryHelpers.AddQueryString(accountRecoveryDto.ClientURI, param);

            var subject = "Resetowanie hasła w systemie Komdeka";
            var greeting = $"Witaj { user.FirstName },<br><br>";
            var body = "otrzymaliśmy prośbę dotyczącą zresetowania Twojego hasła w systemie Komdeka.<br>" +
                       $"Kliknij poniższy link w celu zresetowania hasła:<br>{ passwordResetToken }<br><br>" +
                       "Jeżeli prośba o zresetowanie hasła nie została wysłana przez Ciebie, zignoruj tę wiadomość.<br><br>";
            var signature = "Pozdrawiam<br>Bartłomiej Czerny<br>Programista/Administrator systemu Komdeka";

            var message = new Message(new string[] { user.Email }, subject, greeting + body + signature);
            await _emailSender.SendEmailAsync(message);

            return Ok();
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto resetPasswordDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
            if (user == null)
                return BadRequest("Konto użytkownika o podanym adresie e-mail nie istnieje.");

            var resetPasswordResult = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.Password);
            if (!resetPasswordResult.Succeeded)
            {
                var errors = resetPasswordResult.Errors.Select(e => e.Description);

                return BadRequest(new { Errors = errors });
            }

            await _userManager.SetLockoutEndDateAsync(user, new DateTime(2000, 1, 1));

            return Ok();
        }
    }
}

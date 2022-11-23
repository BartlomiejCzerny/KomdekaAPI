using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Nie wprowadzono imienia.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nie wprowadzono nazwiska.")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Nie wprowadzono adresu e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nie wprowadzono hasła.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Nie powtórzono hasła.")]
        [Compare("Password", ErrorMessage = "Wprowadzone hasła różnią się.")]
        public string ConfirmPassword { get; set; }

        public string ClientURI { get; set; }
    }
}

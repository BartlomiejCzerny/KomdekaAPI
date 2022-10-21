using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.DataTransferObjects
{
    public class ResetPasswordDto
    {
        [Required(ErrorMessage = "Nie wprowadzono hasła.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Nie powtórzono hasła.")]
        [Compare("Password", ErrorMessage = "Wprowadzone hasła różnią się.")]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string Token { get; set; }
        public bool Succeeded { get; internal set; }
    }
}

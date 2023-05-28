using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Nie wprowadzono imienia.")]
        [StringLength(255, ErrorMessage = "Imię może zawierać maksymalnie 255 znaków.")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nie wprowadzono nazwiska.")]
        [StringLength(255, ErrorMessage = "Nazwisko może zawierać maksymalnie 255 znaków.")]
        public string LastName { get; set; }
    }
}
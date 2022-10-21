using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KomdekaAPI.Entities.DataTransferObjects
{
    public class UserForAuthenticationDto
    {
        [Required(ErrorMessage = "E-mail nie został wprowadzony.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło nie zostało wprowadzone.")]
        public string Password { get; set; }
        public string ClientURI { get; set; }
    }
}

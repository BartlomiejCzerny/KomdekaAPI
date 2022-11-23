using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.DataTransferObjects
{
    public class AccountRecoveryDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string ClientURI { get; set; }
    }
}

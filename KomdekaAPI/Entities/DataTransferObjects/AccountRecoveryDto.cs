using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.DataTransferObjects
{
    public class AccountRecoveryDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string ClientURI { get; set; }
    }
}

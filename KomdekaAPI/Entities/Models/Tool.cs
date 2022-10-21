using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KomdekaAPI.Entities.Models
{
    public class Tool
    {
        [Key]
        [Display(Name = "Numer identyfikacyjny")]
        [Required(ErrorMessage = "Nie wprowadzono numeru identyfikacyjnego.")]
        [MaxLength(15, ErrorMessage = "Numer identyfikacyjny może zawierać maksymalnie 15 znaków.")]
        public string IdNumber { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy.")]
        [MaxLength(255, ErrorMessage = "Nazwa może zawierać maksymalnie 255 znaków.")]
        public string Name { get; set; }

        [Display(Name = "Typ")]
        [Required(ErrorMessage = "Nie wprowadzono typu.")]
        public string Type { get; set; }

        [Display(Name = "Numer fabryczny")]
        [Required(ErrorMessage = "Nie wprowadzono numeru fabrycznego.")]
        [MaxLength(255, ErrorMessage = "Numer fabryczny może zawierać maksymalnie 255 znaków.")]
        public string SerialNumber { get; set; }

        [Display(Name = "Czy podlega obsłudze metrologicznej")]
        public bool? IsMetrologicalService { get; set; }

        //[Display(Name = "Okres ważności")]
        //[DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        //public DateTime PeriodValidity { get; set; }

        [Display(Name = "Interwał obsługi metrologicznej")]
        public string? MetrologicalServiceInterval { get; set; }

        [Display(Name = "Data ostatniej obsługi metrologicznej")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTime? LastMetrologicalService { get; set; }

        [Display(Name = "Ważny do")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTime? ValidUntil { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Nie wybrano statusu.")]
        public string Status { get; set; }
    }
}

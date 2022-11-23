using System;
using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.Models
{
    public class Supplier
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

        [Display(Name = "Ulica")]
        [MaxLength(255, ErrorMessage = "Ulica może zawierać maksymalnie 255 znaków.")]
        public string Street { get; set; }

        [Display(Name = "Numer budynku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru budynku.")]
        [MaxLength(15, ErrorMessage = "Numer budynku może zawierać maksymalnie 15 znaków.")]
        public string BuildingNumber { get; set; }

        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "Nie wprowadzono kodu pocztowego.")]
        [MaxLength(6, ErrorMessage = "Kod pocztowy może zawierać maksymalnie 6 znaków.")]
        public string ZipCode { get; set; }

        [Display(Name = "Miejscowość")]
        [Required(ErrorMessage = "Nie wprowadzono miejscowości.")]
        [MaxLength(255, ErrorMessage = "Miejscowość może zawierać maksymalnie 255 znaków.")]
        public string Place { get; set; }

        [Display(Name = "Zakres działalności")]
        [Required(ErrorMessage = "Nie wprowadzono zakresu działalności.")]
        [MaxLength(500, ErrorMessage = "Zakres działalności może zawierać maksymalnie 500 znaków.")]
        public string ActivitiesRange { get; set; }

        [Display(Name = "Data zatwierdzenia")]
        [Required(ErrorMessage = "Nie wybrano daty zatwierdzenia.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset ApprovalDate { get; set; }

        [Display(Name = "Data wygaśnięcia zatwierdzenia")]
        [Required(ErrorMessage = "Nie wybrano daty wygaśnięcia zatwierdzenia.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset ApprovalExpirationDate { get; set; }

        [Display(Name = "Uwagi")]
        [MaxLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string Remarks { get; set; }
    }
}

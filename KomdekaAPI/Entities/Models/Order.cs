using System;
using System.ComponentModel.DataAnnotations;

namespace KomdekaAPI.Entities.Models
{
    public class Order
    {
        // Karta zamówienia
        [Key]
        [Display(Name = "Numer identyfikacyjny")]
        [Required(ErrorMessage = "Nie wprowadzono numeru identyfikacyjnego.")]
        [StringLength(15, ErrorMessage = "Numer identyfikacyjny może zawierać maksymalnie 15 znaków.")]
        public string IdNumber { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [Range(1, 999999999999999, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNumber { get; set; }

        [Display(Name = "Nazwa zamawiającego")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy zamawiającego.")]
        [StringLength(255, ErrorMessage = "Nazwa zamawiającego może zawierać maksymalnie 255 znaków.")]
        public string CustomerName { get; set; }

        [Display(Name = "Ulica")]
        [StringLength(255, ErrorMessage = "Ulica może zawierać maksymalnie 255 znaków.")]
        public string Street { get; set; }

        [Display(Name = "Numer budynku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru budynku.")]
        [StringLength(15, ErrorMessage = "Numer budynku może zawierać maksymalnie 15 znaków.")]
        public string BuildingNumber { get; set; }

        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "Nie wprowadzono kodu pocztowego.")]
        [StringLength(6, ErrorMessage = "Kod pocztowy musi zawierać 6 znaków.")]
        public string ZipCode { get; set; }

        [Display(Name = "Miejscowość")]
        [Required(ErrorMessage = "Nie wprowadzono miejscowości.")]
        [StringLength(255, ErrorMessage = "Miejscowość może zawierać maksymalnie 255 znaków.")]
        public string Place { get; set; }

        [Display(Name = "Imię osoby zamawiającej")]
        [Required(ErrorMessage = "Nie wprowadzono imienia osoby zamawiającej.")]
        [StringLength(255, ErrorMessage = "Imię osoby zamawiającej może zawierać maksymalnie 255 znaków.")]
        public string CustomerFirstName { get; set; }

        [Display(Name = "Nazwisko osoby zamawiającej")]
        [Required(ErrorMessage = "Nie wprowadzono nazwiska osoby zamawiającej.")]
        [StringLength(255, ErrorMessage = "Nazwisko osoby zamawiającej może zawierać maksymalnie 255 znaków.")]
        public string CustomerLastName { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Nie wybrano daty.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset AdmissionOrderDate { get; set; }

        [Display(Name = "Opis zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono opisu zamówienia.")]
        [StringLength(5000, ErrorMessage = "Opis zamówienia może zawierać maksymalnie 5000 znaków.")]
        public string OrderDescription { get; set; }

        [Display(Name = "Uwagi do zamówienia")]
        [StringLength(5000, ErrorMessage = "Uwagi do zamówienia mogą zawierać maksymalnie 5000 znaków.")]
        public string OrderComments { get; set; }

        [Display(Name = "Podpis osoby zamawiającej")]
        [Required(ErrorMessage = "Podpis osoby zamawiającej jest wymagany.")]
        public bool CustomerSignature { get; set; }

        [Display(Name = "Podpis wykonawcy")]
        [Required(ErrorMessage = "Podpis wykonawcy jest wymagany.")]
        public bool ContractorSignature { get; set; }


        // Przegląd zamówienia
        [Display(Name = "Czy wymagania do zamówienia są odpowiednio zdefiniowane?")]
        [Required(ErrorMessage = "Wymagania do zamówienia muszą być odpowiednio zdefiniowane.")]
        public bool AreRequirementsDefined { get; set; }

        [Display(Name = "Czy wszystkie rysunki i dokumenty są aktualne?")]
        [Required(ErrorMessage = "Wszystkie rysunki i dokumenty muszą być aktualne.")]
        public bool AreDocumentsUpToDate { get; set; }

        [Display(Name = "Czy posiadamy aktualne zatwierdzenia jakości?")]
        [Required(ErrorMessage = "Musimy posiadać aktualne zatwierdzenia jakości.")]
        public bool AreQualityApprovalsUpToDate { get; set; }

        [Display(Name = "Czy proponowani poddostawcy posiadają niezbędne zatwierdzenia?")]
        [Required(ErrorMessage = "Proponowani poddostawcy muszą posiadać niezbędne zatwierdzenia.")]
        public bool HaveSuppliersApprovals { get; set; }

        [Display(Name = "Czy mamy niezbędne procedury produkcji i wyposażenia?")]
        [Required(ErrorMessage = "Musimy mieć niezbędne procedury produkcji i wyposażenia.")]
        public bool HaveProductionAndEquipmentProcedures { get; set; }

        [Display(Name = "Czy mamy niezbędne procedury kontroli?")]
        [Required(ErrorMessage = "Musimy mieć niezbędne procedury kontroli.")]
        public bool HaveControlProcedures { get; set; }

        [Display(Name = "Czy mamy niezbędne zasoby do wykonania wyrobu lub usługi?")]
        [Required(ErrorMessage = "Musimy mieć niezbędne zasoby.")]
        public bool HaveTheResources { get; set; }

        [Display(Name = "Czy mamy wystarczającą ilość pracowników i umiejętności?")]
        [Required(ErrorMessage = "Musimy mieć wystarczającą ilość pracowników i umiejętności.")]
        public bool HaveEmployeesAndSkills { get; set; }

        [Display(Name = "Czy wymagania kontroli pierwszej sztuki jasno zostały zdefiniowane i wzięte pod uwagę?")]
        [Required(ErrorMessage = "Wymagania kontroli pierwszej sztuki muszą być jasno zdefiniowane i wzięte pod uwagę.")]
        public bool AreFirstPieceRequirementsDefined { get; set; }

        [Display(Name = "Czy posiadamy magazyny i zasoby do produkcji?")]
        [Required(ErrorMessage = "Musimy posiadać magazyny i zasoby do produkcji.")]
        public bool HaveWarehousesAndResources { get; set; }

        [Display(Name = "Czy ryzyko zostało ocenione?")]
        [Required(ErrorMessage = "Ryzyko musi zostać ocenione.")]
        public bool HasRiskAssessed { get; set; }

        [Display(Name = "Czy cena na zamówieniu odpowiada cenie oferowanej?")]
        [Required(ErrorMessage = "Cena na zamówieniu musi odpowiadać cenie oferowanej.")]
        public bool IsPriceCorrect { get; set; }

        [Display(Name = "Czy warunki dostaw zostały sprawdzone?")]
        [Required(ErrorMessage = "Warunki dostaw muszą zostać sprawdzone.")]
        public bool AreDeliveryTermsChecked { get; set; }

        [Display(Name = "Wynik przeglądu")]
        public bool OrderReviewResult { get; set; }

        //Wymagania do zamówienia
        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [Range(1, 999999999999999, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNum { get; set; }

        [Display(Name = "Wymagania do zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono wymagań do zamówienia.")]
        [StringLength(5000, ErrorMessage = "Wymagania do zamówienia mogą zawierać maksymalnie 5000 znaków.")]
        public string OrderRequirements { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Nie wybrano daty.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset RequirementsEstablishedDate { get; set; }

        [Display(Name = "Podpis")]
        [Required(ErrorMessage = "Podpis osoby zamawiającej jest wymagany.")]
        public bool OrderingPersonSignature { get; set; }


        // Karta projektu
        [Display(Name = "Numer karty projektu")]
        [Required(ErrorMessage = "Nie wprowadzono numeru karty projektu.")]
        [StringLength(15, ErrorMessage = "Numer karty projektu może zawierać maksymalnie 15 znaków.")]
        public string ProjectCardNumber { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [Range(1, 999999999999999, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNo { get; set; }

        [Display(Name = "Zamawiający")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy zamawiającego.")]
        [StringLength(255, ErrorMessage = "Nazwa zamawiającego może zawierać maksymalnie 255 znaków.")]
        public string OrderingPersonName { get; set; }

        [Display(Name = "Zespół projektowy")]
        [Required(ErrorMessage = "Nie wprowadzono danych zespołu projektowego.")]
        [StringLength(5000, ErrorMessage = "Dane zespołu projektowego mogą zawierać maksymalnie 5000 znaków.")]
        public string ProjectTeam { get; set; }

        [Display(Name = "Nazwa dokumentu")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy dokumentu.")]
        [StringLength(255, ErrorMessage = "Nazwa dokumentu może zawierać maksymalnie 255 znaków.")]
        public string DocumentName { get; set; }

        [Display(Name = "Numer dokumentu")]
        [Required(ErrorMessage = "Nie wprowadzono numeru dokumentu.")]
        [StringLength(255, ErrorMessage = "Numer dokumentu może zawierać maksymalnie 255 znaków.")]
        public string DocumentNumber { get; set; }

        [Display(Name = "Uwagi")]
        [StringLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string Comments { get; set; }

        [Display(Name = "Wynik przeglądu")]
        [Required(ErrorMessage = "Nie wprowadzono wyniku przeglądu.")]
        [StringLength(5000, ErrorMessage = "Wynik przeglądu może zawierać maksymalnie 5000 znaków.")]
        public string ReviewResult { get; set; }

        [Display(Name = "Zidentyfikowane problemy")]
        [StringLength(5000, ErrorMessage = "Zidentyfikowane problemy mogą zawierać maksymalnie 5000 znaków.")]
        public string IdentifiedProblems { get; set; }

        [Display(Name = "Planowane działania")]
        [StringLength(5000, ErrorMessage = "Planowane działania mogą zawierać maksymalnie 5000 znaków.")]
        public string PlannedActivities { get; set; }

        [Display(Name = "Wynik weryfikacji")]
        [Required(ErrorMessage = "Nie wprowadzono wyniku weryfikacji.")]
        [StringLength(5000, ErrorMessage = "Wynik weryfikacji może zawierać maksymalnie 5000 znaków.")]
        public string VerificationResult { get; set; }

        [Display(Name = "Zidentyfikowane problemy")]
        [StringLength(5000, ErrorMessage = "Zidentyfikowane problemy mogą zawierać maksymalnie 5000 znaków.")]
        public string EncounteredProblems  { get; set; }

        [Display(Name = "Planowane działania")]
        [StringLength(5000, ErrorMessage = "Planowane działania mogą zawierać maksymalnie 5000 znaków.")]
        public string PlannedWorks { get; set; }

        [Display(Name = "Wynik walidacji")]
        [Required(ErrorMessage = "Nie wprowadzono wyniku walidacji.")]
        [StringLength(5000, ErrorMessage = "Wynik walidacji może zawierać maksymalnie 5000 znaków.")]
        public string ValidationResult { get; set; }

        [Display(Name = "Zidentyfikowane problemy")]
        [StringLength(5000, ErrorMessage = "Zidentyfikowane problemy mogą zawierać maksymalnie 5000 znaków.")]
        public string Problems { get; set; }

        [Display(Name = "Planowane działania")]
        [StringLength(5000, ErrorMessage = "Planowane działania mogą zawierać maksymalnie 5000 znaków.")]
        public string Activities { get; set; }

        [Display(Name = "Opis zmiany")]
        [StringLength(5000, ErrorMessage = "Opis zmiany może zawierać maksymalnie 5000 znaków.")]
        public string DescriptionOfChange { get; set; }

        [Display(Name = "Numer karty zmian")]
        [StringLength(15, ErrorMessage = "Numer karty zmian może zawierać maksymalnie 15 znaków.")]
        public string ShiftCardNumber { get; set; }

        [Display(Name = "Nazwa dokumentu")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy dokumentu.")]
        [StringLength(255, ErrorMessage = "Nazwa dokumentu może zawierać maksymalnie 255 znaków.")]
        public string DocName { get; set; }

        [Display(Name = "Numer dokumentu / rysunku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru dokumentu / rysunku.")]
        [StringLength(255, ErrorMessage = "Numer dokumentu / rysunku może zawierać maksymalnie 255 znaków.")]
        public string DocumentOrDrawingNumber { get; set; }

        [Display(Name = "Uwagi")]
        [StringLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string Remarks { get; set; }

        [Display(Name = "Dodatkowe informacje")]
        [StringLength(5000, ErrorMessage = "Dodatkowe informacje mogą zawierać maksymalnie 5000 znaków.")]
        public string AdditionalInformation { get; set; }

        [Display(Name = "Dodatkowe uwagi")]
        [StringLength(5000, ErrorMessage = "Dodatkowe uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string AdditionalComments { get; set; }

        [Display(Name = "Zatwierdzenie projektu")]
        [Required(ErrorMessage = "Nie wprowadzono danych zatwierdzenia projektu.")]
        [StringLength(5000, ErrorMessage = "Dane zatwierdzenia projektu mogą zawierać maksymalnie 5000 znaków.")]
        public string ProjectApproval { get; set; }

        [Display(Name = "Podpisy zespołu projektowego")]
        [Required(ErrorMessage = "Podpisy zespołu projektowego są wymagane.")]
        public bool DesignTeamSignatures { get; set; }


        //Przewodnik pracy
        [Display(Name = "Numer przewodnika pracy")]
        [Required(ErrorMessage = "Nie wprowadzono numeru przewodnika pracy.")]
        [StringLength(15, ErrorMessage = "Numer przewodnika pracy może zawierać maksymalnie 15 znaków.")]
        public string JobGuideNumber { get; set; }

        [Display(Name = "Data wydania")]
        [Required(ErrorMessage = "Nie wybrano daty wydania.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę wydania w nieprawidłowym formacie.")]
        public DateTimeOffset ReleaseDate { get; set; }

        [Display(Name = "Klient")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy klienta.")]
        [StringLength(255, ErrorMessage = "Nazwa klienta może zawierać maksymalnie 255 znaków.")]
        public string Customer { get; set; }

        [Display(Name = "Nazwa części")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy części.")]
        [StringLength(255, ErrorMessage = "Nazwa części może zawierać maksymalnie 255 znaków.")]
        public string ProductName { get; set; }

        [Display(Name = "Numer rysunku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru rysunku.")]
        [StringLength(15, ErrorMessage = "Numer rysunku może zawierać maksymalnie 15 znaków.")]
        public string DrawingNumber { get; set; }

        [Display(Name = "Wydanie rysunku")]
        [Required(ErrorMessage = "Nie wprowadzono wydania rysunku.")]
        [Range(1, 999999999999999, ErrorMessage = "Wydanie rysunku może zawierać maksymalnie 15 znaków.")]
        public int DrawingRelease { get; set; }

        [Display(Name = "Materiał")]
        [Required(ErrorMessage = "Nie wprowadzono materiału.")]
        [StringLength(15, ErrorMessage = "Materiał może zawierać maksymalnie 15 znaków.")]
        public string Material { get; set; }

        [Display(Name = "Wytop / atest / dowód dostawy")]
        [Required(ErrorMessage = "Nie wprowadzono wytopu / atestu / dowodu dostawy.")]
        [StringLength(255, ErrorMessage = "Wytop / atest / dowód dostawy może zawierać maksymalnie 255 znaków.")]
        public string MeltCertificateProof { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [Range(1, 999999999999999, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNr { get; set; }

        [Display(Name = "Ilość sztuk")]
        [Required(ErrorMessage = "Nie wprowadzono ilości sztuk.")]
        [Range(1, 999999999999999, ErrorMessage = "Ilość sztuk może zawierać maksymalnie 15 znaków.")]
        public int Quantity { get; set; }

        [Display(Name = "Treść przewodnika pracy")]
        [Required(ErrorMessage = "Nie wprowadzono treści przewodnika pracy.")]
        [StringLength(5000, ErrorMessage = "Treść przewodnika pracy może zawierać maksymalnie 5000 znaków.")]
        public string JobGuideContent { get; set; }


        //Świadectwo jakości
        [Display(Name = "Numer świadectwa jakości")]
        [Required(ErrorMessage = "Nie wprowadzono numeru świadectwa jakości.")]
        [StringLength(15, ErrorMessage = "Numer świadectwa jakości może zawierać maksymalnie 15 znaków.")]
        public string QualityCertificateNumber { get; set; }

        [Display(Name = "Zamawiający")]
        [Required(ErrorMessage = "Nie wprowadzono danych zamawiającego.")]
        [StringLength(255, ErrorMessage = "Dane zamawiającego mogą zawierać maksymalnie 255 znaków.")]
        public string Purchaser { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [Range(1, 999999999999999, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNbr { get; set; }

        [Display(Name = "Lista wykonanych części lub zespołów")]
        [Required(ErrorMessage = "Nie wprowadzono listy wykonanych części lub zespołów.")]
        [StringLength(5000, ErrorMessage = "Lista wykonanych części lub zespołów może zawierać maksymalnie 5000 znaków.")]
        public string MadeProducts { get; set; }

        [Display(Name = "Uwagi i ograniczenia")]
        [StringLength(5000, ErrorMessage = "Uwagi i ograniczenia mogą zawierać maksymalnie 5000 znaków.")]
        public string RemarksAndLimitations { get; set; }

        [Display(Name = "Stanowisko")]
        [Required(ErrorMessage = "Nie wprowadzono stanowiska.")]
        [StringLength(255, ErrorMessage = "Stanowisko może zawierać maksymalnie 255 znaków.")]
        public string Position { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Nie wprowadzono imienia.")]
        [StringLength(255, ErrorMessage = "Imię może zawierać maksymalnie 255 znaków.")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nie wprowadzono nazwiska.")]
        [StringLength(255, ErrorMessage = "Nazwisko może zawierać maksymalnie 255 znaków.")]
        public string LastName { get; set; }

        [Display(Name = "Podpis")]
        [Required(ErrorMessage = "Podpis jest wymagany.")]
        public bool Signature { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Nie wybrano daty.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset Date { get; set; }


        //Ankieta zadowolenia klienta
        [Display(Name = "Uwagi")]
        [StringLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string CustomerComments { get; set; }

        [Display(Name = "Poziom zadowolenia z czasu realizacji zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono poziomu zadowolenia.")]
        [Range(1, 5, ErrorMessage = "Poziom zadowolenia może zawierać cyfrę od 1 do 5.")]
        public int TimeSatisfaction { get; set; }

        [Display(Name = "Poziom zadowolenia z jakości wykonanego zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono poziomu zadowolenia.")]
        [Range(1, 5, ErrorMessage = "Poziom zadowolenia może zawierać cyfrę od 1 do 5.")]
        public int QualitySatisfaction { get; set; }

        [Display(Name = "Podpis osoby zamawiającej")]
        [Required(ErrorMessage = "Podpis osoby zamawiającej jest wymagany.")]
        public bool ClientSignature { get; set; }

        [Display(Name = "Podpis wykonawcy")]
        [Required(ErrorMessage = "Podpis wykonawcy jest wymagany.")]
        public bool ExecutingPersonSignature { get; set; }
    }
}

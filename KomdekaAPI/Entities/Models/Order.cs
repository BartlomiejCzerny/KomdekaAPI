using Org.BouncyCastle.Crypto.Tls;
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
        [MaxLength(15, ErrorMessage = "Numer identyfikacyjny może zawierać maksymalnie 15 znaków.")]
        public string IdNumber { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [MaxLength(15, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNumber { get; set; }

        [Display(Name = "Nazwa zamawiającego")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy zamawiającego.")]
        [MaxLength(255, ErrorMessage = "Nazwa zamawiającego może zawierać maksymalnie 255 znaków.")]
        public string CustomerName { get; set; }

        [Display(Name = "Ulica")]
        [MaxLength(255, ErrorMessage = "Ulica może zawierać maksymalnie 255 znaków.")]
        public string Street { get; set; }

        [Display(Name = "Numer budynku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru budynku.")]
        [MaxLength(15, ErrorMessage = "Numer budynku może zawierać maksymalnie 15 znaków.")]
        public string BuildingNumber { get; set; }

        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "Nie wprowadzono kodu pocztowego.")]
        [MinLength(6, ErrorMessage = "Kod pocztowy musi zawierać 6 znaków.")]
        [MaxLength(6, ErrorMessage = "Kod pocztowy musi zawierać 6 znaków.")]
        public string ZipCode { get; set; }

        [Display(Name = "Miejscowość")]
        [Required(ErrorMessage = "Nie wprowadzono miejscowości.")]
        [MaxLength(255, ErrorMessage = "Miejscowość może zawierać maksymalnie 255 znaków.")]
        public string Place { get; set; }

        [Display(Name = "Imię osoby zamawiającej")]
        [Required(ErrorMessage = "Nie wprowadzono imienia osoby zamawiającej.")]
        [MaxLength(255, ErrorMessage = "Imię osoby zamawiającej może zawierać maksymalnie 255 znaków.")]
        public string CustomerFirstName { get; set; }

        [Display(Name = "Nazwisko osoby zamawiającej")]
        [Required(ErrorMessage = "Nie wprowadzono nazwiska osoby zamawiającej.")]
        [MaxLength(255, ErrorMessage = "Nazwisko osoby zamawiającej może zawierać maksymalnie 255 znaków.")]
        public string CustomerLastName { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Nie wybrano daty.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset AdmissionOrderDate { get; set; }

        [Display(Name = "Opis zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono opisu zamówienia.")]
        [MaxLength(5000, ErrorMessage = "Opis zamówienia może zawierać maksymalnie 5000 znaków.")]
        public string OrderDescription { get; set; }

        [Display(Name = "Uwagi do zamówienia")]
        [MaxLength(5000, ErrorMessage = "Uwagi do zamówienia mogą zawierać maksymalnie 5000 znaków.")]
        public string OrderComments { get; set; }

        [Display(Name = "Podpis osoby zamawiającej")]
        [Required(ErrorMessage = "Nie określono, czy podpisano przez osobę zamawiającą.")]
        public string CustomerSignature { get; set; }

        [Display(Name = "Podpis wykonawcy")]
        [Required(ErrorMessage = "Nie określono, czy podpisano przez wykonawcę.")]
        public string ContractorSignature { get; set; }


        // Przegląd zamówienia
        [Display(Name = "Czy wymagania do zamówienia są odpowiednio zdefiniowane?")]
        [Required(ErrorMessage = "Nie określono, czy wymagania do zamówienia są odpowiednio zdefiniowane.")]
        public string AreRequirementsDefined { get; set; }

        [Display(Name = "Czy wszystkie rysunki i dokumenty są aktualne?")]
        [Required(ErrorMessage = "Nie określono, czy wszystkie rysunki i dokumenty są aktualne.")]
        public string AreDocumentsUpToDate { get; set; }

        [Display(Name = "Czy posiadamy aktualne zatwierdzenia jakości?")]
        [Required(ErrorMessage = "Nie określono, czy posiadamy aktualne zatwierdzenia jakości.")]
        public string AreQualityApprovalsUpToDate { get; set; }

        [Display(Name = "Czy proponowani poddostawcy posiadają niezbędne zatwierdzenia?")]
        [Required(ErrorMessage = "Nie określono, czy proponowani poddostawcy posiadają niezbędne zatwierdzenia.")]
        public string HaveSuppliersApprovals { get; set; }

        [Display(Name = "Czy mamy niezbędne procedury produkcji i wyposażenia?")]
        [Required(ErrorMessage = "Nie określono, czy mamy niezbędne procedury produkcji i wyposażenia.")]
        public string HaveProductionAndEquipmentProcedures { get; set; }

        [Display(Name = "Czy mamy niezbędne procedury kontroli?")]
        [Required(ErrorMessage = "Nie określono, czy mamy niezbędne procedury kontroli.")]
        public string HaveControlProcedures { get; set; }

        [Display(Name = "Czy mamy niezbędne zasoby (narzędzia, przyrządy, wyposażenie) do wykonania wyrobu czy usługi?")]
        [Required(ErrorMessage = "Nie określono, czy mamy niezbędne zasoby.")]
        public string HaveTheResources { get; set; }

        [Display(Name = "Czy mamy wystarczającą ilość pracowników i umiejętności?")]
        [Required(ErrorMessage = "Nie określono, czy mamy wystarczającą ilość pracowników i umiejętności.")]
        public string HaveEmployeesAndSkills { get; set; }

        [Display(Name = "Czy wymagania kontroli pierwszej sztuki jasno zostały zdefiniowane i wzięte pod uwagę?")]
        [Required(ErrorMessage = "Nie określono, czy wymagania kontroli pierwszej sztuki jasno zostały zdefiniowane i wzięte pod uwagę.")]
        public string AreFirstPieceRequirementsDefined { get; set; }

        [Display(Name = "Czy posiadamy magazyny i zasoby do produkcji?")]
        [Required(ErrorMessage = "Nie określono, czy posiadamy magazyny i zasoby do produkcji.")]
        public string HaveWarehousesAndResources { get; set; }

        [Display(Name = "Czy ryzyko zostało ocenione?")]
        [Required(ErrorMessage = "Nie określono, czy ryzyko zostało ocenione.")]
        public string HasRiskAssessed { get; set; }

        [Display(Name = "Czy cena na zamówieniu odpowiada cenie oferowanej?")]
        [Required(ErrorMessage = "Nie określono, czy cena na zamówieniu odpowiada cenie oferowanej.")]
        public string IsPriceCorrect { get; set; }

        [Display(Name = "Czy warunki dostaw zostały sprawdzone?")]
        [Required(ErrorMessage = "Nie określono, czy warunki dostaw zostały sprawdzone.")]
        public string AreDeliveryTermsChecked { get; set; }

        //Wymagania do zamówienia
        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [MaxLength(15, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNum { get; set; }

        [Display(Name = "Wymagania do zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono wymagań do zamówienia.")]
        [MaxLength(5000, ErrorMessage = "Wymagania do zamówienia mogą zawierać maksymalnie 5000 znaków.")]
        public string OrderRequirements { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Nie wybrano daty.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset RequirementsEstablishedDate { get; set; }

        [Display(Name = "Podpis")]
        [Required(ErrorMessage = "Nie określono, czy podpisano przez osobę zamawiającą.")]
        public string OrderingPersonSignature { get; set; }

        // Karta projektu
        [Display(Name = "Numer")]
        [Required(ErrorMessage = "Nie wprowadzono numeru.")]
        [MaxLength(15, ErrorMessage = "Numer może zawierać maksymalnie 15 znaków.")]
        public string ProjectCardNumber { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [MaxLength(15, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNo { get; set; }

        [Display(Name = "Zamawiający")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy zamawiającego.")]
        [MaxLength(255, ErrorMessage = "Nazwa zamawiającego może zawierać maksymalnie 255 znaków.")]
        public string OrderingPersonName { get; set; }

        [Display(Name = "Zespół projektowy")]
        [MaxLength(5000, ErrorMessage = "Dane zespołu projektowego mogą zawierać maksymalnie 5000 znaków.")]
        public string ProjectTeam { get; set; }

        [Display(Name = "Nazwa dokumentu")]
        [MaxLength(255, ErrorMessage = "Nazwa dokumentu może zawierać maksymalnie 255 znaków.")]
        public string DocumentName { get; set; }

        [Display(Name = "Numer dokumentu")]
        [Required(ErrorMessage = "Nie wprowadzono numeru dokumentu.")]
        [MaxLength(15, ErrorMessage = "Numer dokumentu może zawierać maksymalnie 15 znaków.")]
        public int DocumentNumber { get; set; }

        [Display(Name = "Uwagi")]
        [MaxLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string Comments { get; set; }

        [Display(Name = "Wynik przeglądu")]
        [Required(ErrorMessage = "Nie wprowadzono wyniku przeglądu.")]
        [MaxLength(5000, ErrorMessage = "Wynik przeglądu może zawierać maksymalnie 5000 znaków.")]
        public string ReviewResult { get; set; }

        [Display(Name = "Zidentyfikowane problemy")]
        [MaxLength(5000, ErrorMessage = "Zidentyfikowane problemy mogą zawierać maksymalnie 5000 znaków.")]
        public string IdentifiedProblems { get; set; }

        [Display(Name = "Planowane działania")]
        [MaxLength(5000, ErrorMessage = "Planowane działania mogą zawierać maksymalnie 5000 znaków.")]
        public string PlannedActivities { get; set; }

        [Display(Name = "Wynik weryfikacji")]
        [Required(ErrorMessage = "Nie wprowadzono wyniku weryfikacji.")]
        [MaxLength(5000, ErrorMessage = "Wynik weryfikacji może zawierać maksymalnie 5000 znaków.")]
        public string VerificationResult { get; set; }

        [Display(Name = "Zidentyfikowane problemy")]
        [MaxLength(5000, ErrorMessage = "Zidentyfikowane problemy mogą zawierać maksymalnie 5000 znaków.")]
        public string EncounteredProblems  { get; set; }

        [Display(Name = "Planowane działania")]
        [MaxLength(5000, ErrorMessage = "Planowane działania mogą zawierać maksymalnie 5000 znaków.")]
        public string PlannedWorks { get; set; }

        [Display(Name = "Wynik walidacji")]
        [Required(ErrorMessage = "Nie wprowadzono wyniku walidacji.")]
        [MaxLength(5000, ErrorMessage = "Wynik walidacji może zawierać maksymalnie 5000 znaków.")]
        public string ValidationResult { get; set; }

        [Display(Name = "Zidentyfikowane problemy")]
        [MaxLength(5000, ErrorMessage = "Zidentyfikowane problemy mogą zawierać maksymalnie 5000 znaków.")]
        public string Problems { get; set; }

        [Display(Name = "Planowane działania")]
        [MaxLength(5000, ErrorMessage = "Planowane działania mogą zawierać maksymalnie 5000 znaków.")]
        public string Activities { get; set; }

        [Display(Name = "Opis zmiany")]
        [MaxLength(5000, ErrorMessage = "Opis zmiany może zawierać maksymalnie 5000 znaków.")]
        public string DescriptionOfChange { get; set; }

        [Display(Name = "Numer karty zmian")]
        [MaxLength(15, ErrorMessage = "Numer karty zmian może zawierać maksymalnie 15 znaków.")]
        public string ShiftCardNumber { get; set; }

        [Display(Name = "Nazwa dokumentu")]
        [MaxLength(255, ErrorMessage = "Nazwa dokumentu może zawierać maksymalnie 255 znaków.")]
        public string DocName { get; set; }

        [Display(Name = "Numer dokumentu/rysunku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru dokumentu/rysunku.")]
        [MaxLength(255, ErrorMessage = "Numer dokumentu/rysunku może zawierać maksymalnie 255 znaków.")]
        public string DocumentOrDrawingNumber { get; set; }

        [Display(Name = "Uwagi")]
        [MaxLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string Remarks { get; set; }

        [Display(Name = "Dodatkowe informacje")]
        [MaxLength(5000, ErrorMessage = "Dodatkowe informacje mogą zawierać maksymalnie 5000 znaków.")]
        public string AdditionalInformation { get; set; }

        [Display(Name = "Dodatkowe uwagi")]
        [MaxLength(5000, ErrorMessage = "Dodatkowe uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string AdditionalComments { get; set; }

        [Display(Name = "Zatwierdzenie projektu")]
        [Required(ErrorMessage = "Nie wprowadzono danych zatwierdzenia projektu.")]
        [MaxLength(5000, ErrorMessage = "Dane zatwierdzenia projektu mogą zawierać maksymalnie 5000 znaków.")]
        public string ProjectApproval { get; set; }

        [Display(Name = "Podpisy zespołu projektowego")]
        [Required(ErrorMessage = "Nie określono, czy podpisano przez osoby z zespołu projektowego.")]
        public string DesignTeamSignatures { get; set; }

        //Przewodnik pracy
        [Display(Name = "Numer")]
        [Required(ErrorMessage = "Nie wprowadzono numeru.")]
        [MaxLength(15, ErrorMessage = "Numer może zawierać maksymalnie 15 znaków.")]
        public string JobGuideNumber { get; set; }

        [Display(Name = "Data wydania")]
        [Required(ErrorMessage = "Nie wybrano daty wydania.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę wydania w nieprawidłowym formacie.")]
        public DateTimeOffset ReleaseDate { get; set; }

        [Display(Name = "Klient")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy klienta.")]
        [MaxLength(255, ErrorMessage = "Nazwa klienta może zawierać maksymalnie 255 znaków.")]
        public string Customer { get; set; }

        [Display(Name = "Nazwa części")]
        [Required(ErrorMessage = "Nie wprowadzono nazwy części.")]
        [MaxLength(255, ErrorMessage = "Nazwa części może zawierać maksymalnie 255 znaków.")]
        public string ProductName { get; set; }

        [Display(Name = "Numer rysunku")]
        [Required(ErrorMessage = "Nie wprowadzono numeru rysunku.")]
        [MaxLength(15, ErrorMessage = "Numer rysunku może zawierać maksymalnie 15 znaków.")]
        public string DrawingNumber { get; set; }

        [Display(Name = "Wydanie rysunku")]
        [Required(ErrorMessage = "Nie wprowadzono wydania rysunku.")]
        [MaxLength(15, ErrorMessage = "Wydanie rysunku może zawierać maksymalnie 15 znaków.")]
        public int DrawingRelease { get; set; }

        [Display(Name = "Materiał")]
        [Required(ErrorMessage = "Nie wprowadzono materiału.")]
        [MaxLength(15, ErrorMessage = "Materiał może zawierać maksymalnie 15 znaków.")]
        public string Material { get; set; }

        [Display(Name = "Wytop / atest / dowód dostawy")]
        [Required(ErrorMessage = "Nie wprowadzono wytopu / atestu / dowodu dostawy.")]
        [MaxLength(255, ErrorMessage = "Wytop / atest / dowód dostawy może zawierać maksymalnie 255 znaków.")]
        public string MeltCertificateProof { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [MaxLength(15, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNr { get; set; }

        [Display(Name = "Ilość sztuk")]
        [Required(ErrorMessage = "Nie wprowadzono ilości sztuk.")]
        [MaxLength(15, ErrorMessage = "Ilość sztuk może zawierać maksymalnie 15 znaków.")]
        public int Quantity { get; set; }

        [Display(Name = "Treść Przewodnika pracy")]
        [Required(ErrorMessage = "Nie wprowadzono treści Przewodnika pracy.")]
        [MaxLength(5000, ErrorMessage = "Treść Przewodnika pracy może zawierać maksymalnie 5000 znaków.")]
        public string JobGuideContent { get; set; }

        //Świadectwo jakości
        [Display(Name = "Numer Świadectwa jakości")]
        [Required(ErrorMessage = "Nie wprowadzono numeru Świadectwa jakości.")]
        [MaxLength(15, ErrorMessage = "Numer Świadectwa jakości może zawierać maksymalnie 15 znaków.")]
        public string QualityCertificateNumber { get; set; }

        [Display(Name = "Zamawiający")]
        [Required(ErrorMessage = "Nie wprowadzono danych zamawiającego.")]
        [MaxLength(255, ErrorMessage = "Dane zamawiającego mogą zawierać maksymalnie 255 znaków.")]
        public string Purchaser { get; set; }

        [Display(Name = "Numer zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono numeru zamówienia.")]
        [MaxLength(15, ErrorMessage = "Numer zamówienia może zawierać maksymalnie 15 znaków.")]
        public int OrderNbr { get; set; }

        [Display(Name = "Lista wykonanych części lub zespołów")]
        [Required(ErrorMessage = "Nie wprowadzono listy wykonanych części lub zespołów.")]
        [MaxLength(5000, ErrorMessage = "Lista wykonanych części lub zespołów może zawierać maksymalnie 5000 znaków.")]
        public string MadeProducts { get; set; }

        [Display(Name = "Uwagi i ograniczenia")]
        [MaxLength(5000, ErrorMessage = "Uwagi i ograniczenia mogą zawierać maksymalnie 5000 znaków.")]
        public string RemarksAndLimitations { get; set; }

        [Display(Name = "Stanowisko")]
        [Required(ErrorMessage = "Nie wprowadzono stanowiska.")]
        [MaxLength(255, ErrorMessage = "Stanowisko może zawierać maksymalnie 255 znaków.")]
        public string Position { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Nie wprowadzono imienia.")]
        [MaxLength(255, ErrorMessage = "Imię może zawierać maksymalnie 255 znaków.")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nie wprowadzono nazwiska.")]
        [MaxLength(255, ErrorMessage = "Nazwisko może zawierać maksymalnie 255 znaków.")]
        public string LastName { get; set; }

        [Display(Name = "Podpis")]
        [Required(ErrorMessage = "Nie określono, czy podpisano.")]
        public string Signature { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Nie wybrano daty.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadzono datę w nieprawidłowym formacie.")]
        public DateTimeOffset Date { get; set; }

        //Ankieta zadowolenia klienta
        [Display(Name = "Uwagi")]
        [MaxLength(5000, ErrorMessage = "Uwagi mogą zawierać maksymalnie 5000 znaków.")]
        public string CustomerComments { get; set; }

        [Display(Name = "Poziom zadowolenia z czasu realizacji zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono poziomu zadowolenia.")]
        [MinLength(1, ErrorMessage = "Poziom zadowolenia może zawierać cyfrę od 1 do 5.")]
        [MaxLength(1, ErrorMessage = "Poziom zadowolenia może zawierać cyfrę od 1 do 5.")]
        public int TimeSatisfaction { get; set; }

        [Display(Name = "Poziom zadowolenia z jakości wykonanego zamówienia")]
        [Required(ErrorMessage = "Nie wprowadzono poziomu zadowolenia.")]
        [MinLength(1, ErrorMessage = "Poziom zadowolenia może zawierać cyfrę od 1 do 5.")]
        [MaxLength(1, ErrorMessage = "Poziom zadowolenia może zawierać cyfrę od 1 do 5.")]
        public int QualitySatisfaction { get; set; }

        [Display(Name = "Podpis osoby zamawiającej")]
        [Required(ErrorMessage = "Nie określono, czy podpisano przez osobę zamawiającą.")]
        public string ClientSignature { get; set; }

        [Display(Name = "Podpis wykonawcy")]
        [Required(ErrorMessage = "Nie określono, czy podpisano przez wykonawcę.")]
        public string ExecutingPersonSignature { get; set; }
    }
}

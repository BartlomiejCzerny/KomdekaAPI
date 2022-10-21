using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KomdekaAPI.Entities.Models
{
    public class Order
    {
        // Karta zamówienia

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int OrderNumber { get; set; }

        public string CustomerName { get; set; }

        public string Street { get; set; }

        public string BuildingNumber { get; set; }

        public string ZipCode { get; set; }

        public string Place { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Date { get; set; }

        public string OrderDescription { get; set; }

        public string OrderComments { get; set; }

        public bool CustomerSignature { get; set; }

        public bool ContractorSignature { get; set; }
        /*
        // Przegląd zamówienia
        public bool AreRequirementsDefined { get; set; }

        public bool AreDocumentsUpToDate { get; set; }

        public bool AreQualityApprovalsUpToDate { get; set; }

        public bool WhetherSuppliersHaveApprovals { get; set; }

        public bool HaveProductionAndEquipmentProcedures { get; set; }

        public bool HaveControlProcedures { get; set; }

        public bool HaveTheResources { get; set; }

        public bool HaveEmployeesAndSkills { get; set; }

        public bool AreFirstPieceRequirementsDefined { get; set; }

        public bool HaveWarehousesAndResources { get; set; }

        public bool HasRiskAssessed { get; set; }

        public bool IsPriceCorrect { get; set; }

        public bool AreDeliveryTermsChecked { get; set; }

        // Karta projektu
        public string ProjectTeam { get; set; }

        public string NameInputDocument { get; set; }

        public int DocumentNumber { get; set; }

        public string InputComments { get; set; }

        public string ReviewResult { get; set; }

        public string IdentifiedProblems { get; set; }

        public string PlannedWork { get; set; }

        public string VerificationResult { get; set; }

        public string EncounteredProblems  { get; set; }

        public string PlannedActivities { get; set; }

        public string ValidationResult { get; set; }

        public string Problems { get; set; }

        public string Activities { get; set; }

        public string DescriptionOfChange { get; set; }

        public string ShiftCardNumber { get; set; }

        public string NameOutputDocument { get; set; }

        public int DocumentOrDrawingNumber { get; set; }

        public string OutputComments { get; set; }

        public string AdditionalInformation { get; set; }

        public string AdditionalComments { get; set; }
        */
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblBusinessUnit
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntBusinessUnitId { get; set; }
      public string StrBusinessUnitCode { get; set; }
      public string StrBusinessUnitName { get; set; }
      public string StrBusinessUnitAddress { get; set; }
      public string? IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
      public bool? IsAttendanceDataProceed { get; set; }
      public string StrImage { get; set; }
      public string StrRegistrationNo { get; set; }
      public DateTime? DteRegistrationDate { get; set; }
      public string StrMasking { get; set; }
      public string StrBusinessUnitGroupName { get; set; }
      public bool? IsVatExempted { get; set; }
   }
}

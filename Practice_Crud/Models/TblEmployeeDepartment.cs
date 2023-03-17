using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblEmployeeDepartment
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntDepartmentId { get; set; }
      public string StrDepartmentCode { get; set; }
      public string StrDepartmentName { get; set; }
      [ForeignKey("Account")]
      public long? IntAccountId { get; set; }
      [NotMapped]
      public Account Account { get; set; }
      [ForeignKey("BusinessUnit")]
      public long? IntBusinessUnitId { get; set; }
      [NotMapped]
      public TblBusinessUnit BusinessUnit { get; set; }
      public string StrRemarks { get; set; }
      public long? IntActionBy { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime? DteServerDateTime { get; set; }
      public bool? IsCorporate { get; set; }
      public bool? IsActive { get; set; }
   }
}

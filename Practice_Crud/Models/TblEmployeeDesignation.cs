using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblEmployeeDesignation
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntDesignationId { get; set; }
      public string StrDesignationCode { get; set; }
      public string StrDesignationName { get; set; }
      [ForeignKey("BusinessUnit")]
      public long? IntBusinessUnitId { get; set; }
      [NotMapped]
      public TblBusinessUnit BusinessUnit { get; set; }  
      [ForeignKey("EmployeeDepartment")]
      public long? DepartmentId { get; set; }
      [NotMapped]
      public TblEmployeeDepartment EmployeeDepartment { get; set; }
      [ForeignKey("Position")]
      public long? IntPosionId { get; set; }
      [NotMapped]
      public TblPosition Position { get; set; }
      public string SrtPositionName { get; set; }
      public bool? IsManagement { get; set; }
      public string StrRemarks { get; set; }
      public string? IntActionBy { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime? DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

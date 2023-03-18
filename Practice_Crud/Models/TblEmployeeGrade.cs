using HRMSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM_API.Models
{
   public class TblEmployeeGrade
   {
      [Key]
      public long IntEmpGradeId { get; set; }
      public string StrEmpGradeCode { get; set; }
      public string StrEmpGradeName { get; set; }
      public long IntSl { get; set; }
      [ForeignKey("TblPosition")]
      public long IntPositionId { get; set; }
      [NotMapped]
      public TblPosition TblPosition { get; set; }
      [ForeignKey("TblPositionGroup")]
      public long IntPositionGroupId { get; set; }
      public TblPositionGroup TblPositionGroup { get; set; } 
      [ForeignKey("Account")]
      public long IntAccountId { get; set; }
      public Account Account { get; set; }   
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
      public string StrEmpBaseGrade { get; set; }

   }
}

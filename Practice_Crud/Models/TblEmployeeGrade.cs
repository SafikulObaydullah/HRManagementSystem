using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblEmployeeGrade
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEmpGradeId { get; set; }
      public string StrEmpGradeCode { get; set; }
      public string StrEmpGradeName { get; set; }
      public long IntSl { get; set; }
      [ForeignKey("position")]
      public long IntPositionId { get; set; }
      public TblPosition position { get; set; }
      [ForeignKey("positionGroup")]
      public long IntPositionGroupId { get; set; }
      [NotMapped]
      public TblPositionGroup positionGroup { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
      public string StrEmpBaseGrade { get; set; }
   }
}

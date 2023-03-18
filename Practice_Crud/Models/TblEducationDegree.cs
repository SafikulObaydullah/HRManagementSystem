using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblEducationDegree
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEducationDegreeId { get; set; }
      public string StrEducationDegree { get; set; }
      [ForeignKey("TblLevelOfEducation")]
      public long IntLevelOfEducationId { get; set; }
      [NotMapped]
      public TblLevelOfEducation TblLevelOfEducation { get; set; }   
      public string StrLevelOfEducation { get; set; }
      public bool IsActive { get; set; }
   }
}

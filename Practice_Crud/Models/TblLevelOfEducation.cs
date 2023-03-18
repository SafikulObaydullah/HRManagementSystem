using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblLevelOfEducation
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntLevelOfEducationId { get; set; }
      public string StrLevelOfEducation { get; set; }
      public bool IsActive { get; set; }
   }
}

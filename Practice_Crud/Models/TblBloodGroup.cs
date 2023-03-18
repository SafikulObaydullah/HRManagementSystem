using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblBloodGroup
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntBloodGroupId { get; set; }
      public string StrBloodGroupName { get; set; }
      public bool? IsActive { get; set; }
   }
}

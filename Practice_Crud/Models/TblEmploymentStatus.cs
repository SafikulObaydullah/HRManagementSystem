using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblEmploymentStatus
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEmploymentStatusId { get; set; }
      public string StrEmploymentStatus { get; set; }
      public bool? IsActive { get; set; }
   }
}

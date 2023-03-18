using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblSupervisor
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long? IntSupervisorLineManagerId { get; set; }
      public string? SupervisorName { get; set; }
      [ForeignKey("lineManager")]
      public long LineManagerId { get; set; }
      [NotMapped]
      public TblLineManager lineManager { get; set; } 
   }
}

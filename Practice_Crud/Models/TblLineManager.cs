using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblLineManager
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long LineManagerId { get; set; }   
      public string LineManagerName { get; set; }  
   }
}

using System.ComponentModel.DataAnnotations;

namespace HRM_API.Models
{
   public class TblEmploymentStatus
   {
      [Key]
      public long IntEmploymentStatusId { get; set; }
      public string StrEmploymentStatus { get; set; }
      public bool? IsActive { get; set; }
   }
}

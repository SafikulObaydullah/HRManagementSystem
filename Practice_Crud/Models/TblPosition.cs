using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblPosition
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntPositionId { get; set; }
      public string StrPositionCode { get; set; }
      public string StrPositionName { get; set; }
      [ForeignKey("TblPositionGroup")]
      public long IntPositionGroupId { get; set; }
      [NotMapped]
      public TblPositionGroup TblPositionGroup { get; set; }   
      public string? IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

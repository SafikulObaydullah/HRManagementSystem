using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblEmploymentType
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEmploymentTypeId { get; set; }
      public string StrEmploymentType { get; set; }
      [ForeignKey("Account")]
      public long IntAccountId { get; set; }
      [NotMapped]
      public Account Account { get; set; }   
      [ForeignKey("TblBusinessUnit")]
      public long IntBusinessUnitId { get; set; }
      [NotMapped]
      public TblBusinessUnit TblBusinessUnit { get; set; }  
      public string? IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

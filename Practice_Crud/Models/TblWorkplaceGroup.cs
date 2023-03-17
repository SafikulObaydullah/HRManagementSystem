using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblWorkplaceGroup
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntWorkplaceGroupId { get; set; }
      public string StrWorkplaceGroupName { get; set; }
      public string StrWorkplaceGroupCode { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

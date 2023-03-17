using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblPositionGroup
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntPositionGroupId { get; set; }
      public string StrPositionGroupCode { get; set; }
      public string StrPositionGroupName { get; set; }
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
   public class TblDivision
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntDivisionId { get; set; }
      public string StrDivisionGeocode { get; set; }
      public string StrDivision { get; set; }
      [ForeignKey("Country")]
      public long IntCountryId { get; set; }
      [NotMapped]
      public TblCountry Country { get; set; }
      public bool? IsActive { get; set; }
   }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblDistrict
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntDistrictId { get; set; }
      [ForeignKey("Division")]
      public long IntDivisionId { get; set; }
      public TblDivision Division { get; set; }
      public string StrDistrictGeocode { get; set; }
      public string StrDistrictName { get; set; }
      [ForeignKey("Country")]
      public long IntCountryId { get; set; }
      public TblCountry Country { get; set; }   
      public long IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

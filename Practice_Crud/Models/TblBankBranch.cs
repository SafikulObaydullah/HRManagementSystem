using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public partial class TblBankBranch
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntBankBranchId { get; set; }
      public string StrBankBranchCode { get; set; }
      public string StrBankBranchName { get; set; }
      public string StrBankBranchAddress { get; set; }
      [ForeignKey("Country")]
      public long? IntCountryId { get; set; }
      public TblCountry Country { get; set; }
      [ForeignKey("TblBank")]
      public long? IntBankId { get; set; }
      public TblBank TblBank { get; set; }
      public string StrBankName { get; set; }
      public string StrBankShortName { get; set; }
      public string StrBankCode { get; set; }
      public long? IntActionBy { get; set; }
      public string StrRoutingNo { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime? DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

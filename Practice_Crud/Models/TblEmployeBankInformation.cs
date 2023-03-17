using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_Crud.Models
{
   public class TblEmployeBankInformation
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEmployeeBankInfoId { get; set; }
      [ForeignKey("tblEmployeeBasicInfo")]
      public long IntEmployeeId { get; set; }
      public TblEmployeeBasicInfo tblEmployeeBasicInfo { get; set; }
      public string StrEmployeeCode { get; set; }
      [ForeignKey("Bank")]
      public long IntBankId { get; set; }
      [NotMapped]
      public TblBank Bank { get; set; }
      public string StrBankName { get; set; }
      [ForeignKey("BankBranch")]
      public long IntBankBranchId { get; set; }
      [NotMapped]
      public TblBankBranch BankBranch { get; set; }
      public string StrBankBranchName { get; set; }
      public string StrBankRoutingNumber { get; set; }
      public string StrAccountNumber { get; set; }
      public string StrAccountName { get; set; }
      [ForeignKey("TblBusinessUnit")]
      public long IntBusinessunitId { get; set; }
      [NotMapped]
      public TblBusinessUnit TblBusinessUnit { get; set; }
      public long IntActionBy { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool IsActive { get; set; }
      public string StrDocumentPath { get; set; }
      public string StrSwiftCode { get; set; }
      [ForeignKey("Country")]
      public long? IntCountryId { get; set; }
      public TblCountry Country { get; set; }   
      public string StrDistrictName { get; set; }
      [ForeignKey("TblDistrict")]
      public long? IntDistrictId { get; set; }
      [NotMapped]
      public TblDistrict TblDistrict { get; set; } 
   }
}

using HRMSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRMSystem.DTO
{
   public  class BankBranchDTO
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntBankBranchId { get; set; }
      public string StrBankBranchName { get; set; }
      public string StrBankBranchCode { get; set; }
      public string StrBankBranchAddress { get; set; }
      public long? IntCountryId { get; set; }
      public long? IntBankId { get; set; }
      //public string StrBankName { get; set; }
      //public string StrBankShortName { get; set; }
      //public string StrBankCode { get; set; }
      public string? IntActionBy { get; set; }
      public string StrRoutingNo { get; set; }
      public DateTime? DteLastActionDateTime { get; set; }
      public DateTime? DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

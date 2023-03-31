using HRMSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRMSystem.DTO
{
   public  class CountryDTO
   {
      public long IntCountryId { get; set; }
      public string StrCountryCode { get; set; }
      public string StrDialingCode { get; set; }
      public string StrCountryName { get; set; }
      public string? IntActionBy { get; set; }
      public DateTime DteLastActionDateTime { get; set; }
      public DateTime DteServerDateTime { get; set; }
      public bool? IsActive { get; set; }
   }
}

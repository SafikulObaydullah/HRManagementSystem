using System.ComponentModel.DataAnnotations;

namespace HRMSystem.Models
{
   public class EmployeeBasiceInfo
   {
      [Key]
      public long Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public string Address { get; set; }
   }
}

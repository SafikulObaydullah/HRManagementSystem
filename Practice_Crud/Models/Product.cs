using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Crud.Models
{
   public class Product
   {
      [Key]
      public int ProductId { get; set; }
      public string Name { get; set; }
      public float Price { get; set; }
      public bool isDisCountApplied { get; set; }
   }
}

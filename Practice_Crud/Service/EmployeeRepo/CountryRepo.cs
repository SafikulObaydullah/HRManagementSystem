using HRM_API.Interfaces;
using System;

namespace HRMSystem.Models
{
   public class CountryRepo : GenericRepository<TblCountry>, ICountryRepository
   {
      public CountryRepo(ApplicationContext context) : base(context)
      {

      }

      public void Dispose()
      {
         throw new NotImplementedException();
      }
   }
}

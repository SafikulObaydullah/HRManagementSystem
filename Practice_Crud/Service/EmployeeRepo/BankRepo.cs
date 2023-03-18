using System;

namespace HRMSystem.Models
{
   public class BankRepo : GenericRepository<TblBank>, IBankRepository
   {
      public BankRepo(ApplicationContext context) : base(context)
      {

      }

      public void Dispose()
      {
         throw new NotImplementedException();
      }
   }
}

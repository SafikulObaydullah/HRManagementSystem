using System;

namespace Practice_Crud.Models
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

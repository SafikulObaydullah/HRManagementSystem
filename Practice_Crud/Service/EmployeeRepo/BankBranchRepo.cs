using System;

namespace HRMSystem.Models
{
   public class BankBranchRepo : GenericRepository<TblBankBranch>, IBankBranchRepository
   {
      public BankBranchRepo(ApplicationContext context) : base(context)
      {

      }

      public void Dispose()
      {
         throw new NotImplementedException();
      }
   }
}

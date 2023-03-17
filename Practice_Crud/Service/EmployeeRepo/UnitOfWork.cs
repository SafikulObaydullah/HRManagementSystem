
using System;

namespace Practice_Crud.Models
{
   public class UnitOfWork : IUnitOfWork
   {
      private readonly ApplicationContext _context;
      public IBankBranchRepository BranchRepository { get; }

      public IBankRepository BankRepository { get; }

      public UnitOfWork(ApplicationContext context,
         IBankBranchRepository bankBranchRepository,
         IBankRepository bankRepository)
      {
         this._context = context;
         this.BranchRepository = bankBranchRepository;
         this.BankRepository = bankRepository;
      }
      public int Complete()
      {
         return _context.SaveChanges();
      }
      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }
      protected virtual void Dispose(bool disposing)
      {
         if (disposing)
         {
            _context.Dispose();
         }
      }
   }
}

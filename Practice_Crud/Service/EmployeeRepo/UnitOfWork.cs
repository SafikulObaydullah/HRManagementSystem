
using HRM_API.Interfaces;
using System;

namespace HRMSystem.Models
{
   public class UnitOfWork : IUnitOfWork
   {
      private readonly ApplicationContext _context;
      public IBankBranchRepository BranchRepository { get; }
      public IBankRepository BankRepository { get; }
      public ICountryRepository CountryRepository { get; }

      public UnitOfWork(ApplicationContext context,
         IBankBranchRepository bankBranchRepository,
         IBankRepository bankRepository,
         ICountryRepository countryRepository)
      {
         this._context = context;
         this.BranchRepository = bankBranchRepository;
         this.BankRepository = bankRepository;
         this.CountryRepository= countryRepository;
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

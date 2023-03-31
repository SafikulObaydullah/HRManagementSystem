using HRM_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
   public interface IUnitOfWork : IDisposable
   {
      IBankBranchRepository BranchRepository { get; }
      IBankRepository BankRepository { get; }
      ICountryRepository CountryRepository { get; }

      int Complete();
   }
}

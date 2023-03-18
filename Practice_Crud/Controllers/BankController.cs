using Microsoft.AspNetCore.Mvc;
using HRMSystem.DTO;
using HRMSystem.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRMSystem.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class BankController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      public readonly ApplicationContext _context;
      public BankController(ApplicationContext context,IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         _context= context;
      }
      [HttpGet]
      [Route("GetBankInfo")]
      public async Task<IActionResult> GetBankInfo()
      {
         var data = await _unitOfWork.BankRepository.GetAll();
         if (data == null)
         {
            return NotFound();
         }
         return Ok(data);
      }
      [HttpGet("GetBankInfoById")]
      public async Task<IActionResult> GetBankInfoById(long BranchId)
      {
         var bankDetails = await _unitOfWork.BankRepository.Get(BranchId);

         if (bankDetails != null)
         {
            return Ok(bankDetails);
         }
         else
         {
            return BadRequest();
         }
      }
      [HttpPost]
      [Route("CreateBank")]
      public IActionResult CreateBank(BankDTO obj)
      {
         TblBank bank = new TblBank()
         {
            StrBankName = obj.StrBankName,
            StrBankShortName= obj.StrBankShortName,
            StrBankCode= obj.StrBankCode,
            DteServerDateTime= obj.DteServerDateTime,
            DteLastActionDateTime= obj.DteLastActionDateTime,
            IntActionBy = obj.IntActionBy,
            IsActive= obj.IsActive,
         };
         var result = _unitOfWork.BankRepository.Add(bank);
         _unitOfWork.Complete();
         if (result is not null) 
         return Ok("Bank Created");
         else return BadRequest("Error in Creating the Bank");
      }

      [HttpPut]
      [Route("UpdateBank")]
      public IActionResult UpdateBank(TblBank bank)
      {
         _unitOfWork.BankRepository.Update(bank);
         _unitOfWork.Complete();
         return Ok("Bank Info Updated");
      }
   }
}

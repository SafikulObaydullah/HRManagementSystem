using Microsoft.AspNetCore.Mvc;
using Practice_Crud.DTO;
using Practice_Crud.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice_Crud.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class BankBranchController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ApplicationContext _context;
      public BankBranchController(ApplicationContext context,IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         _context = context;
      }
      [HttpGet]
      [Route("GetBankBranchInfo")]
      public async Task<IActionResult> GetBankBranchInfo()
      {
         var data =await _unitOfWork.BranchRepository.GetAll();
         if (data == null)
         {
            return NotFound();
         }
         return Ok(data);
      }
      [HttpGet("GetBranchInfoById")]
      public async Task<IActionResult> GetBranchInfoById(long BranchId)
      {
         var branchDetails = await _unitOfWork.BranchRepository.Get(BranchId);

         if (branchDetails != null)
         {
            return Ok(branchDetails);
         }
         else
         {
            return BadRequest();
         }
      }
      //[HttpGet]
      //[Route("GetBankBranchInfo")]
      //public List<BankBranchDTO> GetBankBranchInfo()
      //{
      //   List<BankBranchDTO> data = (from branch in _context.tblBankBranches
      //              where branch.IsActive== true
      //              select new BankBranchDTO()
      //              {
      //                 StrBankBranchName= branch.StrBankBranchName,
      //                 StrBankBranchAddress= branch.StrBankBranchAddress,
      //                 StrBankBranchCode= branch.StrBankBranchCode,
      //                 StrBankCode= branch.StrBankCode,
      //                 StrBankName= branch.StrBankName,
      //                 StrBankShortName= branch.StrBankShortName,
      //                 StrRoutingNo= branch.StrRoutingNo,
      //                 DteLastActionDateTime= branch.DteLastActionDateTime,
      //                 DteServerDateTime= branch.DteServerDateTime,
      //              }).ToList();
      //  //return _unitOfWork.BranchRepository.GetAll();
      //  return data;
      //}

      // GET api/<EmployeeBasicInfoController>/5
      //[HttpGet("{id}")]
      //public IEnumerable<EmployeeBasiceInfo> Get(long id)
      //{
      //   var data = _conttext.EmployeeBasiceInfo.Where(x => x.Id == id).ToList();
      //   return data;
      //}
      [HttpPost]
      [Route("CreateBankBranch")]
      public IActionResult CreateBankBranch(BankBranchDTO branch)
      {
         TblBankBranch bankBranch = new TblBankBranch()
         {
            StrBankBranchName = branch.StrBankBranchName,   
            StrBankBranchAddress= branch.StrBankBranchAddress, 
            StrBankBranchCode= branch.StrBankBranchCode,   
            StrRoutingNo= branch.StrRoutingNo,  
            DteServerDateTime= branch.DteServerDateTime, 
            DteLastActionDateTime= branch.DteLastActionDateTime,  
            IntActionBy = branch.IntActionBy,
            IntBankId= branch.IntBankId,
            IntCountryId= branch.IntCountryId,
            IsActive= branch.IsActive, 
         };
         var result = _unitOfWork.BranchRepository.Add(bankBranch);
         _unitOfWork.Complete();
         if (result is not null) 
         return Ok("Branch Created");
         else return BadRequest("Error in Creating the Product");
      }

      [HttpPut]
      [Route("UpdateBankBranch")]
      public IActionResult UpdateBankBranch(BankBranchDTO branch)
      {
         var updata = _context.tblBankBranches.Where(x=>x.IntBankBranchId== branch.IntBankBranchId).FirstOrDefault(); 
         if (updata != null)
         {
            updata.StrBankBranchName= branch.StrBankBranchName;
            updata.StrBankBranchAddress = branch.StrBankBranchAddress;
            updata.StrBankBranchCode = branch.StrBankBranchCode;
            updata.StrRoutingNo = branch.StrRoutingNo;
            updata.DteServerDateTime = branch.DteServerDateTime;
            updata.DteLastActionDateTime = branch.DteLastActionDateTime;
            updata.IntCountryId = branch.IntCountryId;
            updata.IntBankId = branch.IntBankId;
            updata.IntActionBy = branch.IntActionBy;
            updata.IsActive = true;

         }
         _unitOfWork.BranchRepository.Update(updata);
         _unitOfWork.Complete();
         return Ok("branch Updated");
      }
   }
}

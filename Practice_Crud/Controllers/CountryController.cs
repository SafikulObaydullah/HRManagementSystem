using Microsoft.AspNetCore.Mvc;
using HRMSystem.DTO;
using HRMSystem.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRMSystem.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class CountryController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      public readonly ApplicationContext _context;
      public CountryController(ApplicationContext context,IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         _context= context;
      }
      [HttpGet]
      [Route("GetCountryInfo")]
      public async Task<IActionResult> GetCountryInfo()
      {   try
          {
            var data = await _unitOfWork.CountryRepository.GetAll();
            if (data == null)
            {
               return NotFound();
            }
            return Ok(data);

          }
          catch (Exception ex) { return BadRequest(ex.Message); }
      }
      [HttpGet("GetCountryInfoById")]
      public async Task<IActionResult> GetCountryInfoById(long CountryId)
      {     try
            {
            var countryDetails = await _unitOfWork.CountryRepository.Get(CountryId);

            if (countryDetails != null)
            {
               return Ok(countryDetails);
            }
            else
            {
               return BadRequest();
            }
         }
         catch (Exception ex) { return BadRequest(ex.Message); }
      }
      [HttpPost]
      [Route("CreateCountry")]
      public IActionResult CreateCountry(CountryDTO obj)
      {
         try
         {
            TblCountry country = new TblCountry()
            {
               StrCountryName = obj.StrCountryName,
               StrCountryCode = obj.StrCountryCode,
               StrDialingCode = obj.StrDialingCode,
               DteServerDateTime = obj.DteServerDateTime,
               DteLastActionDateTime = obj.DteLastActionDateTime,
               IntActionBy = obj.IntActionBy,
               IsActive = true,
            };
            var result = _unitOfWork.CountryRepository.Add(country);
            _unitOfWork.Complete();
            if (result is not null)
               return Ok("Country Created");
            else return BadRequest("Error in Creating the country");
         }
         catch (Exception ex)
         {
            return BadRequest(ex.Message);
         }
      }

      [HttpPut]
      [Route("UpdateCountry")]
      public IActionResult UpdateCountry(TblCountry country)
      {
         try
         {
            _unitOfWork.CountryRepository.Update(country);
            _unitOfWork.Complete();
            return Ok("Country Info Updated");
         }
         catch (Exception ex)
         {
            return BadRequest(ex.Message);
         }
      }
      //[HttpDelete("DeleteCountry")]
      //public string DeleteCountry(long id)
      //{
      //   try
      //   {
      //      var countryDetails =  _unitOfWork.CountryRepository.Get(id);
      //      _context.Country.Remove(countryDetails);
      //      _unitOfWork.Complete();
      //      if (countryDetails != null)
      //      {
      //         return Ok(countryDetails);
      //      }
      //      else
      //      {
      //         return BadRequest();
      //      }
      //   }
      //   catch (Exception ex)
      //   {
      //      return "";
      //   }
      //}
   }
}

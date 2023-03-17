using Microsoft.AspNetCore.Mvc;
using Practice_Crud.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice_Crud.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class EmployeeBasicInfoController : ControllerBase
   {
      public readonly ApplicationContext _conttext;
      public EmployeeBasicInfoController(ApplicationContext conttext)
      {
         _conttext = conttext;
      }

      // GET: api/<EmployeeBasicInfoController>
      [HttpGet]
      public IEnumerable<EmployeeBasiceInfo> Get()
      {
         return _conttext.EmployeeBasiceInfo.ToList();
      }

      // GET api/<EmployeeBasicInfoController>/5
      [HttpGet("{id}")]
      public IEnumerable<EmployeeBasiceInfo> Get(long id)
      {
         var data = _conttext.EmployeeBasiceInfo.Where(x=>x.Id== id).ToList();
         return data;
      }

      // POST api/<EmployeeBasicInfoController>
      [HttpPost]
      public string Post([FromBody] EmployeeBasiceInfo employee)
      {
         var data = _conttext.EmployeeBasiceInfo.Add(employee);
         _conttext.SaveChanges();
         return "Saved Successfully";
      }

      // PUT api/<EmployeeBasicInfoController>/5
      [HttpPut("{id}")]
      public string Put([FromBody] EmployeeBasiceInfo employee)
      {
         //var data = _conttext.EmployeeBasiceInfo.Where(x=>x.Id== employee.Id).FirstOrDefault();  
         _conttext.EmployeeBasiceInfo.Update(employee);
         _conttext.SaveChanges();
         return "Updated Successfully";
      }

      // DELETE api/<EmployeeBasicInfoController>/5
      [HttpDelete("{id}")]
      public string Delete(int id)
      {
         var data = _conttext.EmployeeBasiceInfo.Where(x=>x.Id== id).FirstOrDefault();
         _conttext.Remove(data);
         _conttext.SaveChanges();
         return "Successfully Deleted";
      }
   }
}

namespace HRM_API.Models
{
   public class TblAttendance
   {
     
     public long Id { get; set; }
     public string  Name { get; set; }
     public string Holiday { get; set; }
     public DateTime Weekday { get; set; }
     public string Absent { get; set; }
     public string Present { get; set; }
     public string LeaveWithPay { get; set; }
     public string LeaveWithoutPay { get; set; }
     public string Default { get; set; }
     public string HalfDay { get; set; }
   }
}

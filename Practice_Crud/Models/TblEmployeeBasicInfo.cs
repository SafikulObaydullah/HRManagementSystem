using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practice_Crud.Models
{
   public  class TblEmployeeBasicInfo
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long IntEmployeeId { get; set; }
      public string? strEmployeeCode { get; set; } = "";
      [Required]
      [StringLength(50)]
      public string? EmployeeFirstName { get; set; }
      public string? MiddleName { get; set; }
      public string? LastName { get; set; }
      public string? EmployeeFullName { get; set; }
      public long? AccountId { get; set; }
      [ForeignKey("TblBusinessUnit")]
      public long? BusinessunitId { get; set; }
      [NotMapped]
      public TblBusinessUnit TblBusinessUnit { get; set; }
      [ForeignKey("Department")]
      public long? DepartmentId { get; set; }
      [NotMapped]
      public TblEmployeeDepartment Department { get; set; }
      [ForeignKey("Designation")]
      public long? DesignationId { get; set; }
      [NotMapped]
      public TblEmployeeDesignation Designation { get; set; }
      public DateTime? JoiningDate { get; set; }
      public string? PresentAddress { get; set; }
      public string? PermanentAddress { get; set; }
      [ForeignKey("Country")]
      public long? CountryId { get; set; }
      [NotMapped]
      public TblCountry Country { get; set; }
      public string? ContactNumber { get; set; }
      public string? AlternativeContactNumber { get; set; }
      public string? Email { get; set; }
      public DateTime? DateOfBirth { get; set; }
      public string? FatherName { get; set; }
      public string? MotherName { get; set; }
      [ForeignKey("BloodGroup")]
      public long? BloodGroupId { get; set; }
      [NotMapped]
      public TblBloodGroup BloodGroup { get; set; }
      [ForeignKey("Supervisor")]
      public long? SupervisorId { get; set; }
      [NotMapped]
      public TblSupervisor Supervisor { get; set; }
      [ForeignKey("WorkplaceGroup")]
      public long? WorkplaceGroupId { get; set; }
      public TblWorkplaceGroup WorkplaceGroup { get; set; }
      [ForeignKey("Position")]
      public long? PositionId { get; set; }
      public TblPosition Position { get; set; }
      [ForeignKey("TblEmployeeGrade")] 
      public long? EmpGradeId { get; set; }
      public TblEmployeeGrade TblEmployeeGrade { get; set; }
      [ForeignKey("tblEmploymentType")]
      public long? EmploymentTypeId { get; set; }
      public TblEmploymentType tblEmploymentType { get; set; }
      [ForeignKey("LineManager")]
      public long? LineManagerId { get; set; }
      [NotMapped]
      public TblLineManager LineManager { get; set; }
      public string? LineManagerCode { get; set; }
      [ForeignKey("tblEmploymentStatus")]
      public long? EmploymentStatusId { get; set; }
      [NotMapped]
      public TblEmploymentStatus tblEmploymentStatus { get; set; }   
      public long? ActionBy { get; set; }
      public decimal? BasicSalary { get; set; }
      public decimal? GrossSalary { get; set; }
   }
}

using HRM_API.Entities;
using HRM_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HRMSystem.Models
{
   public class ApplicationContext :IdentityDbContext<IdentityUser>
   {
      public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
      {

      }
      protected override void OnModelCreating(ModelBuilder builder)
      {
         base.OnModelCreating(builder);
         //builder.ApplyConfiguration(new CountryConfiguration());
         //builder.ApplyConfiguration(new HotelConfiguration());
         builder.ApplyConfiguration(new RoleConfiguration());
      }
      public DbSet<EmployeeBasiceInfo> EmployeeBasiceInfo { get;set; }
      public DbSet<TblBloodGroup> BloodGroup { get; set; }
      public DbSet<TblBusinessUnit> BusinessUnit { get; set; }
      public DbSet<TblCountry> Country { get; set; }
      public DbSet<TblDivision> Division { get; set; }
      public DbSet<TblDistrict> District { get; set; }
      public DbSet<TblEducationDegree> EducationDegree { get; set; }
      public DbSet<TblEmployeBankInformation> EmployeBankInformation { get; set; }
      public DbSet<TblEmployeeBasicInfo> TblEmployeeBasicInfos { get; set; }
      public DbSet<TblEmployeeDepartment> EmployeeDepartment { get; set; }
      public DbSet<TblEmployeeDesignation> tblEmployeeDesignations { get; set; }
      public DbSet<TblEmployeeGrade> EmployeeGrades { get; set; }
      public DbSet<TblEmploymentStatus> EmployeeEmploymentStatus { get; set; }
      public DbSet<TblEmploymentType> EmployeeEmploymentType { get; set; }
      public DbSet<TblLevelOfEducation> tblLevelOfEducations { get; set; }
      public DbSet<TblLineManager> LineManager { get; set; }
      public DbSet<TblPosition> Positions { get; set; }
      public DbSet<TblPositionGroup> PositionGroups { get; set; }
      public DbSet<TblSupervisor> Supervisors { get; set; }
      public DbSet<TblWorkplaceGroup> WorkplaceGroups { get; set; }
      public DbSet<TblBank> tblBanks { get; set; }
      public DbSet<TblBankBranch> tblBankBranches { get; set; }
      public DbSet<Account> Accounts { get; set; }
   }
}

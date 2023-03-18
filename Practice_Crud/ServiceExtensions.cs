using HRMSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace HRM_API
{
   public static class ServiceExtensions
   {
      public static void ConfigureIdentity(this IServiceCollection services)
      {
         var builder = services.AddIdentityCore<IdentityUser>(q => { q.User.RequireUniqueEmail = true; });

         builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
         builder.AddTokenProvider("HRM_API", typeof(DataProtectorTokenProvider<IdentityUser>));
         builder.AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
      }
   }
}

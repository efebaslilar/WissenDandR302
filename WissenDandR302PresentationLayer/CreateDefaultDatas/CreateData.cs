using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WissenDandR302DataAccessLayer.ContextInfo;
using WissenDandR302EntityLayer.AllEnums;
using WissenDandR302EntityLayer.IdentityModels;

namespace WissenDandR302PresentationLayer.CreateDefaultDatas
{
    public static class CreateData
    {
        public static string LoggedInUser { get; set; }

        public static IApplicationBuilder PrepareData(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var serviceProvider = scopedServices.ServiceProvider;

            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();

            CreateAllRoles(roleManager);
            CreateDefaultAdmin(userManager);

            return app;
        }
        public static void CreateAllRoles(RoleManager<AppRole> roleManager)
        {
            try
            {
                string[] allRoles = Enum.GetNames(typeof(AllRoles));
                foreach (string role in allRoles)
                {
                    if (!roleManager.RoleExistsAsync(role).Result)
                    {
                        //eğer o rol yoksa ekle
                        AppRole r = new AppRole()
                        {
                            Name = role,
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                            Description = $"Sistem tarafından '{role}' rolü oluşturuldu."
                        };
                        var result = roleManager.CreateAsync(r).Result;
                    }
                }
            }
            catch (Exception)
            {


            }
        }

        public static void CreateDefaultAdmin(UserManager<AppUser> userManager)
        {
            try
            {
                var allUsers = userManager.Users.ToList();
                bool adminExist = false;
                foreach (AppUser item in allUsers)
                {
                    if (userManager.IsInRoleAsync(item, AllRoles.Admin.ToString()).Result)
                    {
                        adminExist = true;
                        break;
                    }
                }
                if (!adminExist)
                {
                    AppUser admin = new AppUser()
                    {
                        Name = "Admin",
                        Surname = "Admin",
                        Email = "w302dandr@gmail.com",
                        IsDeleted = false,
                        CreatedDate = DateTime.Now,
                        EmailConfirmed = true,
                        UserName = "w302dandr@gmail.com"
                    };
                    var result = userManager.CreateAsync(admin, "12345").Result;
                    if (result.Succeeded)
                    {
                        var roleResult = userManager.AddToRoleAsync(admin, AllRoles.Admin.ToString()).Result;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

using Microsoft.AspNetCore.Identity;
using MyMuseumTattooStudio.Web.Models;

namespace MyMuseumTattooStudio.Web.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<Artist> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                var newAdminUser = new Artist
                {
                    UserName = "admin",
                    Email = "benmgier82@gmail.com"
                };

                IdentityResult result = userManager.CreateAsync(newAdminUser, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(newAdminUser, "Administrator").Wait();
                    userManager.AddToRoleAsync(newAdminUser, "Artist").Wait();
                }
            }
        }
    }
}

using Microsoft.AspNetCore.Identity;

namespace MyMuseumTattooStudio.Web.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                var _newAdminUser = new IdentityUser
                {
                    UserName = "admin",
                    Email = "benmgier82@gmail.com"
                };

                IdentityResult result = userManager.CreateAsync(_newAdminUser, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(_newAdminUser, "Administrator").Wait();
                }
            }
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyMuseumTattooStudio.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() },
                new IdentityRole() { Name = "Employee", NormalizedName = "EMPLOYEE".ToUpper() }
            );
            
            base.OnModelCreating(modelBuilder);
        }

    }
}

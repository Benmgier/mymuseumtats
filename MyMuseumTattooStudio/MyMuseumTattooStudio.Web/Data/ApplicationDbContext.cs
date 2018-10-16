using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyMuseumTattooStudio.Web.Models;
using MyMuseumTattooStudio.Web.Areas.Admin.Models;

namespace MyMuseumTattooStudio.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public virtual DbSet<Artist> Artists { get; set; }

        public virtual DbSet<Photo> Photos { get; set; }

        public virtual DbSet<PhotoCategory> PhotoCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() },
                new IdentityRole() { Name = "Artist", NormalizedName = "ARTIST".ToUpper() }
            );

            modelBuilder.Entity<PhotoCategory>().HasData(
                new PhotoCategory() { Id = 1, Name = "COLOR" },
                new PhotoCategory() { Id = 2, Name = "BLK-GRY" },
                new PhotoCategory() { Id = 3, Name = "PORTRAITS" },
                new PhotoCategory() { Id = 4, Name = "COVER-UPS" },
                new PhotoCategory() { Id = 5, Name = "PERMANENT-CORRECTIVE-COSMETICS" }
            );

            base.OnModelCreating(modelBuilder);
        }
        

    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MyMuseumTattooStudio.Web.Areas.Admin.Models
{
    public class ArtistViewModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required]
        [Display(Name = "Username / Login")]
        public string UserName { get; set; }

        public string Bio { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public IFormFile AvatarImage { get; set; }

        public byte[] AvatarImageData { get; set; }

        [Display(Name = "User Roles")]
        public IList<string> UserRoles { get; set; }

        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}

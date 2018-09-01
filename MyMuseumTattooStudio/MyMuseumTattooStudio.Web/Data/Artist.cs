using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyMuseumTattooStudio.Web.Models
{
    public class Artist : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Bio { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public byte[] AvatarImage { get; set; }
    }
}

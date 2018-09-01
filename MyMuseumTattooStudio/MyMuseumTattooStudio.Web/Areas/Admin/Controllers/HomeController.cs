using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMuseumTattooStudio.Web.Models;
using System.Linq;

namespace MyMuseumTattooStudio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class HomeController : Controller
    {
        private readonly UserManager<Artist> _userManager;
        public HomeController(UserManager<Artist> userManager)
        {
            _userManager = userManager;
        }

        // ADMIN
        // create artist
        // update artist
        // delete artist
        // update whatever content they need

        // ARTIST
        // update indivudual profile ONLY
        // Add photos for their gallery
        // upload photo
        // remove photos from their gallery

        // image heirarchy: ImageCategory > Image

        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
    }
}

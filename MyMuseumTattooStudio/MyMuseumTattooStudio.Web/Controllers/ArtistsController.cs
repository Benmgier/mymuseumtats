using Microsoft.AspNetCore.Mvc;
using MyMuseumTattooStudio.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMuseumTattooStudio.Web.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var photoCategories = _context.PhotoCategories.ToList();

            return View(photoCategories);
        }

    }
}

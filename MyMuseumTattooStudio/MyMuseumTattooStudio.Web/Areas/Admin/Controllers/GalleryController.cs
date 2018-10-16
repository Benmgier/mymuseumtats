using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMuseumTattooStudio.Web.Data;
using MyMuseumTattooStudio.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyMuseumTattooStudio.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Artist, Administrator")]
    [Area("Admin")]
    public class GalleryController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<Artist> _userManager;
        private readonly Artist _currentUser;

        public GalleryController(ApplicationDbContext db, UserManager<Artist> userManager, IHttpContextAccessor httpContext)
        {
            _db = db;
            _userManager = userManager;
            var test = httpContext;
            _currentUser = _userManager.GetUserAsync(httpContext.HttpContext.User).Result;
           
        }

        public async Task<IActionResult> Index()
        {
            var photos = _db.Photos
                            .Where(p => p.UserId == _currentUser.Id)
                            .Include(p => p.PhotoCategory)
                            .ToList();
            return View(photos);
        }


        public async Task<IActionResult> Create(List<IFormFile> files)
        {
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await formFile.CopyToAsync(memoryStream);
                        _db.Photos.Add(new Photo()
                        {
                            Data = memoryStream.ToArray(),
                            UserId = _currentUser.Id,
                            PhotoCategoryId = 1
                        });

                    }
                }
            }
            _db.SaveChanges();


            return RedirectToAction("Index", "Gallery", new { area = "Admin" });
        }
    }
}

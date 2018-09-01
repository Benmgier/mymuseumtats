using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyMuseumTattooStudio.Web.Areas.Admin.Models;
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
    public class ArtistController : Controller
    {
        private readonly UserManager<Artist> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ArtistController(RoleManager<IdentityRole> roleManager, UserManager<Artist> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var artist = await _userManager.FindByIdAsync(id);

            if (artist == null)
            {
                return NotFound();
            }
            
            var usersRoles = await _userManager.GetRolesAsync(artist);
            
            var viewModel = new ArtistViewModel()
            {
                Id = artist.Id,
                UserName = artist.UserName,
                FirstName = artist.FirstName,
                LastName = artist.LastName,
                Email = artist.Email,
                Bio = artist.Bio,
                Facebook = artist.Facebook,
                Instagram = artist.Instagram,
                AvatarImageData = artist.AvatarImage,
                UserRoles = usersRoles
            };
           
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ArtistViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var existingArist = await _userManager.FindByIdAsync(model.Id);

                    if (existingArist != null)
                    {
                        existingArist.FirstName = model.FirstName;
                        existingArist.LastName = model.LastName;
                        existingArist.Email = model.Email;
                        existingArist.Bio = model.Bio;
                        existingArist.Facebook = model.Facebook;
                        existingArist.Instagram = model.Instagram;

                        if (model.AvatarImage != null)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await model.AvatarImage.CopyToAsync(memoryStream);
                                existingArist.AvatarImage = memoryStream.ToArray();
                            }
                        }

                        var allRoles = await _userManager.GetRolesAsync(existingArist);

                        await this._userManager.RemoveFromRolesAsync(existingArist, allRoles);

                        if (model.UserRoles != null)
                        {
                            await this._userManager.AddToRolesAsync(existingArist, model.UserRoles);
                        }

                        await _userManager.UpdateAsync(existingArist);
                    }
                    else
                    {
                        return NotFound();
                    }
                  
                }
                catch(Exception ex)
                {
                    throw ex;
                }

                
                return RedirectToAction("Index", "Home", new {area = "Admin"});
                
            }

            return View(model);
        }

        public async Task<IActionResult> UploadImages(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMuseumTattooStudio.Web.Controllers
{
    public class CosmeticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

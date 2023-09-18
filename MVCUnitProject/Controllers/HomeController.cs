using Microsoft.AspNetCore.Mvc;
using MVCUnitProject.Models;
using System.Diagnostics;

namespace MVCUnitProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(JordanModel model)
        {
            return View(model);
        }
    }
}
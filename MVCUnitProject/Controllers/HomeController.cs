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

        public IActionResult Display(JordanModel model)
        {
            return View(model);
        }
    }
}
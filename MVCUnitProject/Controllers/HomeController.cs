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
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Error");
        }

        public IActionResult Error(JordanModel model) 
        {
           return View(model);
        }
    }
}
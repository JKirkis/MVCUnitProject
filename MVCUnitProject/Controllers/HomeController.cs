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

        // Welcome page if name is entered
        public IActionResult Welcome(JordanModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Error");
        }

        // Error view
        public IActionResult Error(JordanModel model) 
        {
           return View(model);
        }
    }
}
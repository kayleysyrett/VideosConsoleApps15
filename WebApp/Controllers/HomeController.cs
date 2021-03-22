using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using ConsoleAppProject.App02;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DistanceConverter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMICalculator bmi)
        {
            return View();
        }

        [HttpGet]
        public IActionResult OutputWho()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudentMarks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

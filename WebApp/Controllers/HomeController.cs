using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if(converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
       public IActionResult BMICalculator(BMICalculator bmi)
        {
            if (bmi.Centimetres > 140)
            {
                bmi.CalculateMetric();
            }
            else if (bmi.Feet > 4 && bmi.Stones > 6)
            {
                bmi.CalculateImperial();
            }
            else
            {
                ViewBag.Error = "you have entered values too small for any adult!";
                return View();
            }

            double bmiIndex = bmi.Index;
            return RedirectToAction("CalculateWho", new { bmiIndex });
        }

        [HttpGet]
        public IActionResult CalculateWho(double bmiIndex)
        {
            return View(bmiIndex);
        }

        [HttpGet]
        public IActionResult StudentGrades()
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

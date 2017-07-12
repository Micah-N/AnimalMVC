using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Zoo()
        {
            Animal test = new Animal();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

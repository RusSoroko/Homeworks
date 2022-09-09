using Homework15_ModelsAndViews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework15_ModelsAndViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static readonly Fish[] fish = new[]
        {
            new Fish("Nemo", 2, 20),
            new Fish("Dora", 1, 25),
            new Fish("Shark", 20, 50)
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTransportByViewData()
        {
            string fishData = string.Empty;
            foreach (var fish in fish)
            {
                fishData = fishData + "Name: " + fish.Name + "; " + "Weight: " + fish.Weight + "; " + "Speed: " + fish.Speed + "; ";
            }
            ViewData["FishData"] = fishData;
            return View();
        }

        public IActionResult DataTransportByViewBag()
        {
            ViewBag.FishBag = fish;
            return View();
        }

        public IActionResult DataTransportByModel()
        {
            ViewData["Karp"] = "Karp";
            ViewBag.Ten = "10";
            return View(fish);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
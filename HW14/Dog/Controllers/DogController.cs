using Dog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dog.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VetApplication()
        {
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult VetApplication(DogViewModel dog)
        {
            Console.WriteLine($"{dog.DogName}, {dog.OwnerName}, {dog.Age}, {dog.Weight}");
            return VetApplication();
        }

    }
}

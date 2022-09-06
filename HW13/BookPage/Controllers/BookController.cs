using BookPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookPage.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var book = new BookViewModel("Shantaram", "G.D. Roberts", 934);
            return View(book);
        }
    }
}

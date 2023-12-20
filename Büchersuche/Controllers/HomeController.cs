using Büchersuche.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Büchersuche.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Books()
        {
            return PartialView();
        }
        public IActionResult AlleBooks()
        {
            BooksDBContext context = new BooksDBContext();

            return View(context.Books);
        }
        public IActionResult Suche()
        {
            return View();
        }
        public IActionResult BookSuche(string buchname)
        {
            
            BooksDBContext context = new BooksDBContext();
            var books = context.Books.Where(b => b.Title.Contains(buchname)).ToList();
            return PartialView("_allebücher", books);
        }
        public IActionResult SucheKat()
        {
            BooksDBContext context = new BooksDBContext();

            return View(context.Categories);
        }
        public IActionResult BookSucheKat(int katid)
        {
            BooksDBContext context = new BooksDBContext();
            var books = context.Books.Where(b => b.CategoryId == katid);
            return PartialView("_allebücher", books);
        }

        

    }
}

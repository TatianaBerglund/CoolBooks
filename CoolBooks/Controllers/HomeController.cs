using CoolBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoolBooks.Controllers
{
    public class HomeController : BaseController
    {
        private coolbooks db = new coolbooks();
        public ActionResult Index()
        {
          
            var books = db.Books.OrderByDescending(b => b.Created).Where(b => b.IsDeleted == false);
            ViewData["books"] = books;
            return View();
        }

        public ActionResult About()
        {
           
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
          
            ViewBag.Message = "Your contact page.";
            var Genres = db.Genres.OrderByDescending(g => g.Name).Where(g => g.IsDeleted == false);
            return View(Genres.ToList());
            

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoolBooks.Models;

namespace CoolBooks.Controllers
{
    public class BaseController : Controller
    {
        private coolbooks db = new coolbooks();
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            ViewData["Genres"] = db.Genres.ToList();
        }
    }
}
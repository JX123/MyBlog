using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Picture = (from p in db.Blogs select p.Picture).ToList();
            ViewBag.NewBlog=(from n in db.Blogs select n).Take(5).ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Guestbook()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult BlogShow()
        {
            return View();
        }
    }
}
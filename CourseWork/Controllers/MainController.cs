using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseWork.Controllers
{
    public class MainController : Controller
    {
        private WaterMeterContext db = new WaterMeterContext();
        [Authorize(Roles="user")]
        public ActionResult UserMain()
        {
            return View(db.Users.Where(x => x.Email == User.Identity.Name).ToList()[0]);
        }

        [Authorize(Roles="admin")]
        public ActionResult AdminMain()
        {
            return View();
        }
    }
}
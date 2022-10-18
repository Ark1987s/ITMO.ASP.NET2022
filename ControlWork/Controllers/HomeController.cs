using ControlWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

            return View();
        }
        ProgressContext db = new ProgressContext();
        private void Study()
        {
            var study = db.Progresss.ToList<Progress>();
            ViewBag.Study = study;
        }
        [HttpGet]
        public ActionResult Data()
        {
            Study();

            return View();
        }

        public ActionResult Form()
        {
            Study();

            return View("Form");
        }

        [HttpPost]
        public ActionResult Data(Progress newProgress)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Progresss.Add(newProgress);

            db.SaveChanges();

            return View();
        }
    }
}
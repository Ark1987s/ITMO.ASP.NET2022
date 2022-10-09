using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Lab01.Ex01.WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        /* public ActionResult Index()
         {
             return View();
         }*/
        public string Start()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        }
    }
}
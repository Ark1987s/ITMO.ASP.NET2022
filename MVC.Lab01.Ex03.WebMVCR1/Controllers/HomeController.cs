using MVC.Lab01.Ex03.WebMVCR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Lab01.Ex03.WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        /* public ActionResult Index()
         {
             return View();
         }*/
        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}
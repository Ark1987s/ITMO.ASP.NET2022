﻿using ControlWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlWork.Controllers
{
    public class HomeController : Controller
    {
        ProgressContext db = new ProgressContext();
        public ActionResult Index()
        {
            return View(db.Progresses);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]       
        public ActionResult AddStudent([Bind(Include = "Student, Maths, Physics, History")] Progress progress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(progress).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(progress);
        
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
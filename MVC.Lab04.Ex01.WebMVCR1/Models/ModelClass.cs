﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Lab04.Ex01.WebMVCR1.Models
{
    public class ModelClass
    {
        public static string ModelHello()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Properties.Controllers
{
    public class HomeController : Controller

    {
        //index method is used for load and view default msg or data 
        //public string Index()
        //{
        //    return "first method from home controler class"; 
        //}

        public ViewResult Index()
        {
            ViewBag.Title = 123;  //view data 
            return View();
        }

        public ViewResult AboutUs ()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}

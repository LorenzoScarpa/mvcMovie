using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            int a = 35*4+2;
            ViewBag.Number=a;
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        
        //public string Welcome2(int? id, int numTimes = 1)
        //{
        //     return HttpUtility.HtmlEncode("Hello " + id + ", NumTimes is: " + numTimes);
        //}
    }
}
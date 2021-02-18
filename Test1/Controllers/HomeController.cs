using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test1.Models;
using Newtonsoft.Json;


namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page, And Stuff";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Stable Circutis";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult abc()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetInfo(person p)
        {
     
            p.name = "";

            int result = 0;
      
            return Json(p);
            //return Json("test", JsonRequestBehavior.AllowGet);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }//class


}//nx

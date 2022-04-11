using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ROHIT_CORE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ROHIT_CORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Name = "This us Rohit gupta";
            ViewBag.Age = 21;
            ViewBag.Date_and_Time = DateTime.Now;
            ViewBag.Salary = 1500;
            ViewBag.group = new List<string>()
            {
                "rohit",
                "vikash",
                "neelam",
                "shivam",
                "anjali",
                "sweta",
            };



            ViewData["Name"] = "This us Rohit gupta";
            ViewData["Age"] = 21;
            ViewData["Date_and_Time"] = DateTime.Now;
            ViewData["Salary"] = 1500;
            ViewData["group"] = new List<string>()
            {
                "rohit",
                "vikash",
                "neelam",
                "shivam",
                "anjali",
                "sweta",
            };


            TempData["Name"] = "This us Rohit gupta";
            TempData["Age"] = 21;
            TempData["Date_and_Time"] = DateTime.Now;
            TempData["SAlary"] = 1500;
            TempData["group"]= new List<string>()
            {
                "rohit",
                "vikash",
                "neelam",
                "shivam",
                "anjali",
                "sweta",
            };


            HttpContext.Session.SetString("Name", "ROHIT");
           ViewBag.session = HttpContext.Session.GetString("Name");




            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

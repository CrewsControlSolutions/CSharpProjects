using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationIntro2.Models;
using System.IO;
using System.Data;

namespace WebApplicationIntro2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //this is a method also known as an "action"
        {
            //string text = "hello";
            //System.IO.File.WriteAllText(@"/Users/mikecrews/Documents/TechAcademy/" +
            //    "GitHub/CSharpProjects/WebApplicationIntro2/sample.log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();
            //ViewBag.RandomNumber = num;

            //if (num > 200000)
            //{
            //    return View("Privacy");
            //}

            //return View();

            //return Content("Hello");

            //return RedirectToAction("Privacy");

            //return View("Privacy"); //does not hit controller method

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 97;
            return View(user);
        }

        public IActionResult Privacy(int id=0) //IActionResult is a data type, oddly enough
        {
            ViewBag.Message = id;

            //throw new Exception("Invalid page");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

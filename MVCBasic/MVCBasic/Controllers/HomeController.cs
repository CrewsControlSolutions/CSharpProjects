using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //uses the extensive and powerful ASP Class Library
using Microsoft.Extensions.Logging;
using MVCBasic.Models;

namespace MVCBasic.Controllers
{
    public class HomeController : Controller //inherits from the Controller class
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Message = "Welcome to our Privacy Center, where you'll find legalese-" +
                "loaded explanations on our latest cryptic and crafty practices.";

            return View();
        }

        public IActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Chris",
                LastName = "Crammer"
            };
            return View(dayTimeInstructor);
        }

        public IActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Albert",
                    LastName = "Einstein"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Andrew",
                    LastName = "Doppler"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Von Strauss"
                }
            };

            return View(instructors);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

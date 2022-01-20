using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCBasic.Controllers
{
    public class StudentsController : Controller
    {
        // GET: /Students/
        public IActionResult Index()
        {
            return View();
        }
    }
}

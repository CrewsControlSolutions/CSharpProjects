using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using MVCNewsletterApp.Models;

namespace MVCNewsletterApp.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("Error");
            }
            else
            {
                //string connectionString = @"Data Source = localhost,1433; Database = Newsletter; User Id = sa; Password = ________________";

                //string queryString = @"CREATE TABLE tbl_industries (
                //    industry_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
                //    industry_name VARCHAR(100) NOT NULL,
                //    industry_year INT NOT NULL)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    //command.Parameters.Add("@FirstName", SqlDbType.VarChar);

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}

                return View("Success");
            }
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentOrganizer.Models;

namespace StudentOrganizer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            List<StudentModel> students = new List<StudentModel>();
            students.Add(
                new StudentModel
                {
                    id          = 1,
                    firstName   = "Bob",
                    lastName    = "Samacus",
                    age         = 31,
                    status      = "Active"
                }
            );
            var model = new StudentListModel
            {
                students = students
            };

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

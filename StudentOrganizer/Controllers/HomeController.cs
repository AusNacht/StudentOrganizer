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
            return View();
        }

        [ActionName("UploadStudents")]
        [HttpGet]
        public IActionResult UploadStudents()//(string name)
        {
            //Take in the excel spreadsheet
            //Call service to turn it into data
            //Call validate to validate the data
            //Return it to the View via the StudentListModel

            return RedirectToAction("StudentView", "Student");
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

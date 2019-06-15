using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentOrganizer.Models;

namespace StudentOrganizer.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentView()
        {
            //Take in the excel spreadsheet
            //Call service to turn it into data
            //Call validate to validate the data
            //Return it to the View via the StudentListModel

            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            List<StudentModel> students = new List<StudentModel>();
            students.Add(
                new StudentModel
                {
                    id = 1,
                    firstName = "Bob",
                    lastName = "Samacus",
                    age = 31,
                    status = "Active"
                }
            );
            var model = new StudentListModel
            {
                students = students
            };

            return View(model);
        }
    }
}

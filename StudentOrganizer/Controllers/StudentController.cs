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
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            List<StudentModel> students = new List<StudentModel>();
            students.Add(
                new StudentModel
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Samacus",
                    Age = 31,
                    Status = "Active"
                }
            );
            var model = new StudentListModel
            {
                Students = students
            };

            return View(model);
        }
    }
}

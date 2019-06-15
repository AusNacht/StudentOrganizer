using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentOrganizer.Dao;
using StudentOrganizer.Models;

namespace StudentOrganizer.Controllers
{
    public class StudentController : Controller
    {
        UniversityDatabase _db = new UniversityDatabase();

        public IActionResult StudentView()
        {
            //To get stuff from the URL
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];

            var model = _db.Students.ToList();

            //Add stuff to the model
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
            //var model = new StudentListModel
            //{
            //    Students = students
            //};

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

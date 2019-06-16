using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentOrganizer.Dao;
using StudentOrganizer.Models;
using StudentOrganizer.Services;
using StudentOrganizer.Services.Interfaces;

namespace StudentOrganizer.Controllers
{
    public class StudentController : Controller
    {
        //IStudentService _studentService;
        private IValidatorService _validatorService = new ValidatorService();
        //UniversityDatabase _db = new UniversityDatabase();

        public IActionResult StudentView()
        {
            //Add stuff to the model
            //Turn into students
            //List<StudentModel> students = _studentService.ConvertToStudentList(Dt);
            List<StudentModel> students = DummyData.DummyStudents.getDummyStudentList();

            //Validate
            List<string> errors = _validatorService.validateStudents(students);

            var model = new StudentListModel
            {
                Students = students,
                Errors = errors
            };

            return View(model);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if(_db != null)
        //    {
        //        _db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}

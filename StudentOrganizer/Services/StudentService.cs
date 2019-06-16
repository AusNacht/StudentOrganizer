using System;
using System.Collections.Generic;
using System.Data;
using StudentOrganizer.Models;
using StudentOrganizer.Services.Interfaces;

namespace StudentOrganizer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IValidatorService _validatorService;

        public List<StudentModel> ConvertToStudentList(DataTable dataTable)
        {
            List<StudentModel> students = new List<StudentModel>();

            if(dataTable != null)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    StudentModel student = new StudentModel
                    {
                        Id          = (string)dataTable.Rows[i]["Id"],
                        FirstName   = (string)dataTable.Rows[i]["FirstName"],
                        LastName    = (string)dataTable.Rows[i]["LastName"],
                        Age         = (string)dataTable.Rows[i]["Age"],
                        Status      = (string)dataTable.Rows[i]["Status"]
                    };

                    students.Add(student);
                }
            }

            return students;
        }
    }
}

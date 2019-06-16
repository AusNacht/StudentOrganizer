using System;
using System.Collections.Generic;
using System.Data;
using StudentOrganizer.Models;

namespace StudentOrganizer.Services.Interfaces
{
    public interface IStudentService
    {
        List<StudentModel> ConvertToStudentList(DataTable dataTable);
    }
}

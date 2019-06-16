using System;
using System.Collections.Generic;

namespace StudentOrganizer.Models
{
    public class StudentListModel
    {
        public List<StudentModel>   Students { get; set; }

        public List<string>         Errors { get; set; }
    }
}

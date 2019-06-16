using System;
using System.Collections.Generic;
using StudentOrganizer.Models;

namespace StudentOrganizer.Services.Interfaces
{
    public interface IValidatorService
    {
        List<string> validateStudents(List<StudentModel> students);

        List<string> validateStudent(StudentModel student);

        bool validateString(String incoming, int maxLength,       bool required);

        bool validateInt   (String incoming, bool mustBePositive);

        bool validateStatus(String incoming);
    }
}

using System;
using System.Collections.Generic;
using StudentOrganizer.Services.Interfaces;
using StudentOrganizer.Codes;
using StudentOrganizer.Models;

namespace StudentOrganizer.Services
{
    public class ValidatorService : IValidatorService
    {
        public List<string> validateStudents(List<StudentModel> students)
        {
            List<string> errors = new List<string>();

            foreach(StudentModel student in students)
            {
                errors.AddRange(validateStudent(student));
            }

            return errors;
        }

        public List<string> validateStudent(StudentModel student)
        {
            List<string> errors = new List<string>();

            if (!this.validateInt(student.Id, false))
            {
                errors.Add("Invalid ID");
            }

            if (!this.validateString(student.FirstName, 50, true))
            {
                errors.Add("Invalid First Name");
            }

            if (!this.validateString(student.FirstName, 50, true))
            {
                errors.Add("Invalid Last Name");
            }

            if(!this.validateInt(student.Age, true))
            {
                errors.Add("Invalid Age");
            }

            if (!this.validateStatus(student.Status))
            {
                errors.Add("Invalid Status");
            }

            return errors;
        }

        public bool validateString(String incoming, int maxLength, bool required)
        {
            bool result = false;

            if (String.IsNullOrEmpty(incoming))
            {
                result = !required;
            }
            else result |= incoming.Length <= maxLength;

            return result;
        }

        public bool validateInt(String incoming, bool mustBePositive)
        {
            int result;
            bool success = Int32.TryParse(incoming, out result);

            //Success if int and if it's positive or it's not required to be positive
            return success   && ( (result > 0)    || !mustBePositive );
        }

        public bool validateStatus(String incoming)
        {
            return Status.STATUS_OPTIONS.Contains(incoming);
        }
    }
}

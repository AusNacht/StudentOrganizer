using System;
using System.Collections.Generic;
using StudentOrganizer.Services.Interfaces;

namespace StudentOrganizer.Services
{
    public class ValidatorService : IValidatorService
    {
        // Readonly  variables
        private static readonly List<String> STATUS_OPTIONS = new List<String>( new string[] { "Active", "Inactive", "Hold" } );


        public bool validateString(String incoming, int maxLength, bool required)
        {
            bool result = false;

            if (String.IsNullOrEmpty(incoming))
            {
                result = !required;
            }
            else if (incoming.Length <= maxLength)
            {
                result = true;
            }

            return result;
        }

        //FIXME: need to validate Int, are we getting as strings or something
        public bool validateInt(String incoming, bool mustBePositive, bool required)
        {
            bool result = false;

            if (String.IsNullOrEmpty(incoming) && required)
            {
                result = false;
            }
            //Int32.TryParse(incoming);

            return result;
        }

        public bool validateStatus(String incoming)
        {
            return STATUS_OPTIONS.Contains(incoming);
        }
    }
}

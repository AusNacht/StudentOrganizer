using System;
using System.Collections.Generic;
using StudentOrganizer.Services.Interfaces;
using StudentOrganizer.Codes;

namespace StudentOrganizer.Services
{
    public class ValidatorService : IValidatorService
    {
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
            return Status.STATUS_OPTIONS.Contains(incoming);
        }
    }
}

using System;
namespace StudentOrganizer.Services.Interfaces
{
    public interface IValidatorService
    {
        bool validateString(String incoming, int maxLength,       bool required);

        bool validateInt   (String incoming, bool mustBePositive, bool required);

        bool validateStatus(String incoming);
    }
}

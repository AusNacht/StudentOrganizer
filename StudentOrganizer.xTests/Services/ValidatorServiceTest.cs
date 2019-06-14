using System;
using System.Collections.Generic;
using Xunit;
using StudentOrganizer.Services;

namespace StudentOrganizer.xTests
{
    public class ValidatorServiceTest
    {
        private ValidatorService _validatorService;

        private static readonly List<String> STRING_VALID_LIST1 = new List<String>(new string[] { "ASDF", "qwerwerty", "1234" });
        private static readonly List<String> STRING_VALID_LIST2 = new List<String>(new string[] { "ASDF", "qwerwerty", "1234" });
        private static readonly List<String> STRING_EMPTY_LIST1 = new List<String>(new string[] { "", null });
        private static readonly List<String> STRING_EMPTY_LIST2 = new List<String>(new string[] { "", null });

        private static readonly List<String> INT_SUCCESS_LIST    = new List<String>(new string[] { "" });
        private static readonly List<String> INT_FAIL_LIST       = new List<String>(new string[] { "" });

        private static readonly List<String> STATUS_SUCCESS_LIST = new List<String>(new string[] { "Active", "Inactive", "Hold" } );
        private static readonly List<String> STATUS_FAIL_LIST    = new List<String>(new string[] { "asdf", "2" } );


        [Fact]
        public void validateStringOfCorrectLength()
        {
            _validatorService = new ValidatorService();

            // Strings with valid data and under max length are valid
            foreach(String test in STRING_VALID_LIST1)
            {
                Assert.True(_validatorService.validateString(test, test.Length, false));
            }
        }

        [Fact]
        public void validateStringOfIncorrectLength()
        {
            _validatorService = new ValidatorService();

            // Strings with valid data and over the max length are invalid
            foreach (String test in STRING_VALID_LIST2)
            {
                Assert.False(_validatorService.validateString(test, test.Length - 1, false));
            }
        }

        [Fact]
        public void validateStringEmptyAndNotRequired()
        {
            _validatorService = new ValidatorService();

            // Strings with null or empty values and aren't required are valid
            foreach (String test in STRING_EMPTY_LIST1)
            {
                Assert.True(_validatorService.validateString(test, 1, false));
            }
        }

        [Fact]
        public void validateStringEmptyAndRequired()
        {
            _validatorService = new ValidatorService();

            // Strings with null or empty values and are required are invalid
            foreach (String test in STRING_EMPTY_LIST2)
            {
                Assert.False(_validatorService.validateString(test, 1, true));
            }
        }

        [Fact]
        public void validateIntSuccessTest()
        {
            //FIXME: need to write unit tests for Int
            _validatorService = new ValidatorService();

            Assert.False(_validatorService.validateInt("1", false, false));
        }

        [Fact]
        public void validateStatusValid()
        {
            _validatorService = new ValidatorService();

            foreach (String test in STATUS_SUCCESS_LIST)
            {
                Assert.True(_validatorService.validateStatus(test));
            }
        }

        [Fact]
        public void validateStatusInvalid()
        {
            _validatorService = new ValidatorService();

            foreach (String test in STATUS_FAIL_LIST)
            {
                Assert.False(_validatorService.validateStatus(test));
            }
        }
    }
}

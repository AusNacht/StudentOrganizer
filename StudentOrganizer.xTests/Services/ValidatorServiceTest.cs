using System;
using System.Collections.Generic;
using Xunit;
using StudentOrganizer.Services;

namespace StudentOrganizer.xTests
{
    public class ValidatorServiceTest
    {
        private ValidatorService _validatorService;

        private static readonly List<string> STRING_VALID_LIST = new List<string>(new string[] { "ASDF", "qwerwerty", "1234" });
        private static readonly List<string> STRING_EMPTY_LIST = new List<string>(new string[] { "", null });

        private static readonly List<string> INT_SUCCESS_LIST    = new List<string>(new string[] { "1", "2", "3" });
        private static readonly List<string> INT_FAIL_LIST       = new List<string>(new string[] { "a", "12.324", null });

        private static readonly List<string> STATUS_SUCCESS_LIST = new List<string>(new string[] { "Active", "Inactive", "Hold" } );
        private static readonly List<string> STATUS_FAIL_LIST    = new List<string>(new string[] { "asdf", "2" } );


        [Fact]
        public void validatestringOfCorrectLength()
        {
            _validatorService = new ValidatorService();

            // strings with valid data and under max length are valid
            foreach(string test in STRING_VALID_LIST)
            {
                Assert.True(_validatorService.validateString(test, test.Length, false));
            }
        }

        [Fact]
        public void validatestringOfIncorrectLength()
        {
            _validatorService = new ValidatorService();

            // strings with valid data and over the max length are invalid
            foreach (string test in STRING_VALID_LIST)
            {
                Assert.False(_validatorService.validateString(test, test.Length - 1, false));
            }
        }

        [Fact]
        public void validatestringEmptyAndNotRequired()
        {
            _validatorService = new ValidatorService();

            // strings with null or empty values and aren't required are valid
            foreach (string test in STRING_EMPTY_LIST)
            {
                Assert.True(_validatorService.validateString(test, 1, false));
            }
        }

        [Fact]
        public void validatestringEmptyAndRequired()
        {
            _validatorService = new ValidatorService();

            // strings with null or empty values and are required are invalid
            foreach (string test in STRING_EMPTY_LIST)
            {
                Assert.False(_validatorService.validateString(test, 1, true));
            }
        }

        [Fact]
        public void validateIntSuccessTest()
        {
            _validatorService = new ValidatorService();

            foreach (string test in INT_SUCCESS_LIST)
            {
                Assert.True(_validatorService.validateInt(test, true));
            }
        }

        [Fact]
        public void validateIntInvalidIntTest()
        {
            _validatorService = new ValidatorService();

            foreach(string test in INT_FAIL_LIST)
            {
                Assert.False(_validatorService.validateInt(test, false));
            }
        }

        [Fact]
        public void validateIntValidButNegative1()
        {
            _validatorService = new ValidatorService();

            //-1 is valid if not required
            Assert.True(_validatorService.validateInt("-1", false));
        }

        [Fact]
        public void validateIntValidButNegative2()
        {
            _validatorService = new ValidatorService();

            //Negative 1 is not positive
            Assert.False(_validatorService.validateInt("-1", true));
        }

        [Fact]
        public void validateIntValidButNegative3()
        {
            _validatorService = new ValidatorService();

            //Zero is not positive
            Assert.False(_validatorService.validateInt("0", true));
        }

        [Fact]
        public void validateStatusValid()
        {
            _validatorService = new ValidatorService();

            foreach (string test in STATUS_SUCCESS_LIST)
            {
                Assert.True(_validatorService.validateStatus(test));
            }
        }

        [Fact]
        public void validateStatusInvalid()
        {
            _validatorService = new ValidatorService();

            foreach (string test in STATUS_FAIL_LIST)
            {
                Assert.False(_validatorService.validateStatus(test));
            }
        }
    }
}

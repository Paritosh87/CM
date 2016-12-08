using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Assignments.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDivisors_Input_Valid()
        {
            //Arrange
            var input = 20;
            var output = "{1,2,4,5,10,20}";

            //Act
            var result = Assignments.Divisors.GetDivisors(input);

            //Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void GetDivisors_Input_Valid_Output_LessDivisors_Fail()
        {
            //Arrange
            var input = 20;
            var output = "{1,2,4,5,10}";

            //Act
            var result = Assignments.Divisors.GetDivisors(input);

            //Assert
            Assert.AreNotEqual(output, result);
        }

        [TestMethod]
        public void IsNullOrEmpty_Input_Null_return_True()
        {
            //Arrange
            var output = true;

            //Act
            var result = Assignments.ExtensionMethods.IsNullOrEmpty(null);

            //Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void IsNullOrEmpty_Input_Empty_return_True()
        {
            //Arrange
            var output = true;

            //Act
            var result = Assignments.ExtensionMethods.IsNullOrEmpty("");

            //Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void IsNullOrEmpty_Input_NotEmpty_return_False()
        {
            //Arrange
            var output = false;

            //Act
            var result = Assignments.ExtensionMethods.IsNullOrEmpty("has some value");

            //Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void IsNullOrEmpty_Input_NotEmpty_return_False()
        {
            //Arrange
            var output = false;

            //Act
            var result = Assignments.ExtensionMethods.IsNullOrEmpty("has some value");

            //Assert
            Assert.AreEqual(output, result);
        }
    }
}

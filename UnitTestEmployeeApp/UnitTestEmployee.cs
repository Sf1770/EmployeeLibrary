using System;
using EmployeeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEmployeeApp
{
    [TestClass] //Decoratiors/Annotations/Attributes
    public class UnitTestEmployee
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Employee emp = new Employee();
            string firstName = "john";
            long ssn = 7894561;
            string expectedValue = "1654987nhoj";
            string actualValue = "";
            //Act
            actualValue = emp.GetPassword(firstName, Convert.ToString(ssn));
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

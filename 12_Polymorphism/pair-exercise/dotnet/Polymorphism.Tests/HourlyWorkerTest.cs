using EmployeePayroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Tests
{
    [TestClass]
    public class HourlyWorkerTest
    {
        HourlyWorker hourlyWorker = new HourlyWorker(50, "Adam", "Smith");

        [TestMethod]
        public void CalculateWeeklyPayTest()
        {
            
            double expected = 2000;
            double actual = hourlyWorker.CalculateWeeklyPay(40);

            Assert.AreEqual(expected, actual, "Hourly rate of 50 and worked 40 hours");


            expected = 2750;
            actual = hourlyWorker.CalculateWeeklyPay(50);
            Assert.AreEqual(expected, actual, "Hourly rate of 50 and worked 50 hours");
        }
    }
}

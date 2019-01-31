using EmployeePayroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polymorphism.Tests
{
    [TestClass]
    public class SalaryWorkerTest
    {
        SalaryWorker salaryWorker = new SalaryWorker(60000, "Adam", "Smith");

        [TestMethod]
        public void CalculateWeeklyPayTest()
        {
            double expected = 60000 / (double)52;
            double actual = salaryWorker.CalculateWeeklyPay(40);

            Assert.AreEqual(expected, actual, "Annual Salary of 60000");
        }
    }
}

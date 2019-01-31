using EmployeePayroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polymorphism.Tests
{
    [TestClass]
    public class VolunteerWorkerTest
    {
        VolunteerWorker volunteerWorker = new VolunteerWorker("Adam", "Smith");

        [TestMethod]
        public void CalculateWeeklyPayTest()
        {

            double expected = 0;
            double actual = volunteerWorker.CalculateWeeklyPay(40);

            Assert.AreEqual(expected, actual, "Hourly rate of 50 and worked 40 hours");


            expected = 0;
            actual = volunteerWorker.CalculateWeeklyPay(50);
            Assert.AreEqual(expected, actual, "Hourly rate of 50 and worked 50 hours");
        }
    }
}

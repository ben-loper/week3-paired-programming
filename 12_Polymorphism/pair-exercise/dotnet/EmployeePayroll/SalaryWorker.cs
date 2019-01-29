using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    public class SalaryWorker : IWorker
    {

        private const int weeksInYear = 52;
        public string FirstName { get; }
        public string LastName { get; }
        public double AnnualSalary { get; }

        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            AnnualSalary = annualSalary;
            FirstName = firstName;
            LastName = lastName;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            return AnnualSalary / weeksInYear;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    public class HourlyWorker : IWorker
    {
        private const int weeksInYear = 52;
        public string FirstName { get; }
        public string LastName { get; }
        public double HourlyRate { get; }


        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            HourlyRate = hourlyRate;
            FirstName = firstName;
            LastName = lastName;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = HourlyRate * hoursWorked;
            double overtime = hoursWorked - 40;
            pay = pay + (HourlyRate * overtime * 0.5);

            return pay;
        }
    }
}

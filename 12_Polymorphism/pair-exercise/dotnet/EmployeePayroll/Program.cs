using System;
using System.Collections.Generic;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomHoursWorked = new Random();

            SalaryWorker mickeyMouse = new SalaryWorker(400000, "Mouse", "Mickey");
            HourlyWorker minnieMouse = new HourlyWorker(30, "Mouse", "Minnie");
            VolunteerWorker donaldDuck = new VolunteerWorker("Duck", "Donald");
            HourlyWorker georgeGeff = new HourlyWorker(15, "Geef", "George (Goofy)");
            
            List<IWorker> workers = new List<IWorker>();
            workers.Add(mickeyMouse);
            workers.Add(georgeGeff);
            workers.Add(minnieMouse);
            workers.Add(donaldDuck);

            Console.WriteLine("Employee".PadRight(30) + "Hours Worked".PadRight(30) + "Pay");

            int totalHours = 0;
            double totalPay = 0;

            foreach (IWorker worker in workers)
            {
                string fullName = worker.FirstName + ", " + worker.LastName;
                int hours = randomHoursWorked.Next(0, 168);
                Console.WriteLine(fullName.ToString().PadRight(30) + hours.ToString().PadRight(30) + worker.CalculateWeeklyPay(hours).ToString("C"));
                totalHours += hours;
                totalPay += worker.CalculateWeeklyPay(hours);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Hours: {totalHours}");
            Console.WriteLine($"Total Pay: {totalPay.ToString("C")}");
            Console.ReadKey();
        }
    }
}

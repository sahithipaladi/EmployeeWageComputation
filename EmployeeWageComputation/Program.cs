using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeepresent = 1;
            int empHours = 8;
            int empRatePerHour = 20;

            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (empInput==employeepresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.Read();


        }
    }
}

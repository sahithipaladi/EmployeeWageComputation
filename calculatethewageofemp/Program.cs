using System;

namespace calculatethewageofemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeePresent = 1;
            int empHours = 0;
            int empRatePerHour = 20;
            int empWage = 0;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (empInput == employeePresent)
            {
                Console.WriteLine("Employee is Present");
                empHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHours = 0;
            }
            empWage = empRatePerHour * empHours;
            Console.WriteLine("Employee wage per day =" + empWage);
            Console.Read();
        }
    }
}

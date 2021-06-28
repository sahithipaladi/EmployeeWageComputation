using System;

namespace checktheemployeeparttime
{
    class Program
    {
        static void Main(string[] args)
        {
            int fulltime = 1;
            int parttime = 2;
            int empHours = 0;
            int empRateperHour = 20;
            int empWage = 0;

            Random random = new Random();
            int empInput = random.Next(0, 3);
            if (empInput == fulltime)
            {
                Console.WriteLine("Employee is fulltime");
                empHours = 8;
            }
            else if (empInput == parttime)
            {
                Console.WriteLine("Employee is parttime ");
                empHours = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                
            }
            empWage = empRateperHour * empHours;
            Console.WriteLine("Employee wage per day =" + empWage);
            Console.Read();
        }
    }
}

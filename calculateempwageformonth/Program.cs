using System;

namespace calculateempwageformonth
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empHours = 0;
            int empWage = 0;
            int totalWage = 0;
            const int Emp_rate_per_Hour = 20;
            int Working_days = 20;
            Random random = new Random();
            for (int day = 1; day <= Working_days; day++)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case Full_Time:
                        empHours = 8;
                        break;
                    case Part_Time:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                empWage = Emp_rate_per_Hour * empHours;
                totalWage += empWage;
            }
            Console.WriteLine("Employee Wage for " + Working_days + "DAYS = " + totalWage);
            Console.Read();


                }
    }

}
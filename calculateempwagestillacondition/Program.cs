using System;

namespace calculateempwagestillacondition
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empHours = 0;
            int empWage = 0;
            int workingHrs = 0;
            int totalWage = 0;
            int MAX_Working_Days = 5;
            int MAX_Working_Hrs = 8;
            const int Emp_rate_per_Hour = 20;
            int Working_Days = 2;
            Random random = new Random();
            while (Working_Days <= MAX_Working_Days && workingHrs <= MAX_Working_Hrs)
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
                workingHrs += empHours;
                totalWage += empWage;
                Working_Days++;


            }
            Console.WriteLine("workingHrs =" + workingHrs + "Working_Days =" + Working_Days);
            Console.WriteLine("Employee Wage for " + MAX_Working_Days + "days = " + totalWage);

        }
    }
}

using System;

namespace calculateempwagestillacondition
{
    class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public int MAX_Working_Days = 5;
        public int MAX_Working_Hrs = 8;
        public const int Emp_rate_per_Hour = 20;
         public   void   ComputeWage()
        {
           
            int empHours = 0;
            int empWage = 0;
            int workingHrs = 0;
            int totalWage = 0;
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
                if (empInput !=0)
                {
                    Working_Days++;
                }
             


            }
            Console.WriteLine("workingHrs = {0} working days = {1} ", workingHrs , Working_Days);
            Console.WriteLine("Employee Wage for {0} days = {1} " , MAX_Working_Days , totalWage);

        }
           public  void Main(string[] args)
        {
            ComputeWage();
            Console.Read();
        }
    }
}

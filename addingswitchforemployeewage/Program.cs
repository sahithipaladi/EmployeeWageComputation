using System;

namespace addingswitchforemployeewage
{
    

    class Program
    {
      
        static void Main(string[] args)
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            const int Emp_Rate_Per_Hour = 20;
            int empWage = 0;
            int empHours = 0;


            Random random = new Random();
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
            empWage = Emp_Rate_Per_Hour * empHours;
            Console.WriteLine("Employee wage per day =" + empWage);
            Console.Read();


        }
    }
}

using System;

namespace EmployeeWageComputationpgrm
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("\n Employee Wage Computation \n");
         
            CompanyEmpWage companyEmpWage = new CompanyEmpWage();
            companyEmpWage.addCompanyEmpWage("Dmart", 20, 20, 100);
            companyEmpWage.addCompanyEmpWage("Reliance", 20, 20, 100);
            companyEmpWage.computeEmpWage();
        }
    }
}

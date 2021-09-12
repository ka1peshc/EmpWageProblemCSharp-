using System;
using System.IO;

namespace EmpWageProblem
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmp("Apple", 20, 20, 58);
            empWageBuilder.addCompanyEmp("MT", 25, 10, 70);
            empWageBuilder.addCompanyEmp("Raymond", 15, 25, 60);
            empWageBuilder.computeEmpWage();
        }
    }
}

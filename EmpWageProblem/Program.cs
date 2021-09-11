using System;
using System.IO;

namespace EmpWageProblem
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageCalculator MnM = new EmpWageCalculator("MnM",20,15,85);
            MnM.computeEmpWage();
            Console.WriteLine(MnM.displaySalary());
        }
    }
}

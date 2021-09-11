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
            //Calculating wage using EmpWageCalculator class
            //creating company using object instance
            EmpWageCalculator MnM = new EmpWageCalculator("MnM",20,15,85);
            MnM.computeEmpWage();
            //display employee wage
            Console.WriteLine(MnM.displaySalary());
        }
    }
}

using System;
using System.IO;

namespace EmpWageProblem
{
    public class Program
    {
        public const int IS_PRESENT = 0;
        public const int IS_ABSENT = 1;
        public const int IS_PART_TIME = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}

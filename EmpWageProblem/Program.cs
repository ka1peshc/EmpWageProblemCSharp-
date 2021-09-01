using System;
using System.IO;

namespace EmpWageProblem
{
    public class Program
    {
        public const int IS_PRESENT = 0;
        public const int IS_ABSENT = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOUR = 8;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            int empHour = 0;
            int salary = 0;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            
            if (empCheck == IS_PRESENT)
            {
                empHour = FULL_DAY_HOUR;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHour = 0;
            }
            salary = empHour * WAGE_PER_HOUR;
            Console.WriteLine(salary);
        }
    }
}

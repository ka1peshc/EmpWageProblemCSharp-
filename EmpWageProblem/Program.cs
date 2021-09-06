using System;
using System.IO;

namespace EmpWageProblem
{
    public class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        public static void computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            int empHour = 0, salary = 0, workingDay = 0, totalHours = 0;
            int empCheck;
            Random random = new Random();
            while (workingDay <= numOfWorkingDays && totalHours <= maxHoursPerMonth)
            {
                workingDay++;
                empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHour = 8;
                        break;
                    case IS_FULL_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalHours += empHour;
                Console.WriteLine("Day's {0} Emp hours {1}", workingDay, totalHours);
            }
            salary = totalHours * empRatePerHour;
            Console.WriteLine("total Emp wage for company: {0} is {1}",company,salary);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            computeEmpWage("Dmart",20,2,10);
        }
    }
}

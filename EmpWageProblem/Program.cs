﻿using System;
using System.IO;

namespace EmpWageProblem
{
    public class EmpWageCalculator
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        //variables
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonths;
        private int salary = 0;
        public EmpWageCalculator(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
        }
        public void computeEmpWage()
        {
            int empHour = 0, workingDay = 0, totalHours = 0;
            int empCheck;
            Random random = new Random();
            while (workingDay <= numOfWorkingDays && totalHours <= maxHoursPerMonths)
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
            Console.WriteLine("total Emp wage for company: {0} is {1}", company, salary);
        }

        public string displaySalary()
        {
            return "total Emp wage for company: " + company + " is " + salary;
        }
    }
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

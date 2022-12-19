﻿namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            //Computation

            int empCheck = random.Next(0, 3); ;

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp Wage : " + empWage);
        }
    }
}
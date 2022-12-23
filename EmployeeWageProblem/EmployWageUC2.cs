using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployWageUC2
    {
        public void EmployeeUC2(int empCheck1)
        {
            int IS_PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWages = 0;

            if (empCheck1 == IS_PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages: " + empWages);
        }
    }
}

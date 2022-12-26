using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmployWageUC3
    {
        int empCheck;

        public EmployWageUC3(int empChk)
        {
            this.empCheck = empChk;
        }
        public void EmployeeUC3()
        {
            int IS_FULLTIME = 1;
            int IS_PARTTIME = 2;
            int EMP_RATE_PER_HRS = 20;

            int empHrs = 0;
            int empWages = 0;

            if (this.empCheck == IS_FULLTIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present and doing Fulltime");
            }
            else if (this.empCheck == IS_PARTTIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present and doing Parttime");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWages = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Employee wages:" + empWages);

        }
    }
}

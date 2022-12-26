using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{

    internal class EmployWageUC4
    {

        const int IS_PARTTIME = 1;
        const int IS_FULLTIME = 2;
        const int EMP_RATE_PER_HRS = 20;

        

       
        public void EmployeeUC4(int empCheck)
        {
            int empHrs = 0;
            int empWages = 0;

            switch (empCheck)
            {
                case IS_PARTTIME:
                    empHrs = 4;
                    break;
                case IS_FULLTIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWages = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Employee wages:" + empWages);
        }
    }   
}

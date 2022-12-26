using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployWageUC1
    {
        int empCheck;

        public EmployWageUC1(int empChk)
        {
            this.empCheck = empChk;
        }

        public void EmployeeUC1()
        {
            int IS_PRESENT = 1;
            if (this.empCheck == IS_PRESENT)
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

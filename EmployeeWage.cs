using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmployeeWage
    //The method is checking the Employee is Present or Absent and calculating daily Employee Wage
    {
        public static void CalculateEmployeeWage()
        {
            int EMP_RATE_PER_HOUR = 20;
            int IS_FULL_TIME = 1;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empChk = random.Next(2);

            if (empChk == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage :" + empWage);
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmployeeCheck
        //The method is checking the Employee is Present or Absent
    {
        public static void CheckEmployeePresentOrNot()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empChk = random.Next(2);

            if(empChk == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

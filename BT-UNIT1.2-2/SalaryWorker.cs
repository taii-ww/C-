using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._2_2
{
    internal class SalaryWorker : Employee
    {
        double annualSalary;

        public SalaryWorker(string name, double salary) : base(name)
        {
            annualSalary = salary;
        }

        public override void calcPaidCheck()
        {
            double pay = annualSalary / 12;
            Console.WriteLine(empName + " Salary: " + pay);
        }
    }
}

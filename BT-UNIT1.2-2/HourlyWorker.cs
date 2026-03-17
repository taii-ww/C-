using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._2_2
{
    internal class HourlyWorker : Employee
    {
        double HourlyRate;
        double HoursWorked;

        public HourlyWorker(string name, double rate, double worked) : base(name)
        {
            HourlyRate = rate;
            HoursWorked = worked;
        }

        public override void calcPaidCheck()
        {
            double salary = HourlyRate * HoursWorked;
            Console.WriteLine(empName + "salary: " + salary);
        }
    }
}

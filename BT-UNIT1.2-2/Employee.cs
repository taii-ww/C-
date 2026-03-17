using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._2_2
{
    internal class Employee
    {
        protected string empName;

        public Employee(string name)
        {
            empName = name;
        }

        public virtual void calcPaidCheck()
        {

        }
    }
}

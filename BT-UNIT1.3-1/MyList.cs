using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._3_1
{
    internal class MyList
    {
        public List<int> l = new List<int>();

        public void list()
        {
            l.Add(2);
            l.Add(4);
            l.Add(6);

            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
        }
    }
}

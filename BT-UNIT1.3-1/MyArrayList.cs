using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._3_1
{
    internal class MyArrayList
    {
        public ArrayList ar = new ArrayList();
        public void arraylist()
        {
            ar.Add("Bình");
            ar.Add(12);
            ar.Add(6.7);

            foreach(var item in ar)
            {
                Console.WriteLine(item);
            }
        }
    }
}

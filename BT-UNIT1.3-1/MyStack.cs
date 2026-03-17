using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._3_1
{
    internal class MyStack
    {
        public Stack<int> s = new Stack<int>();
        public void stack()
        {
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(10);
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            s.Pop();
            Console.WriteLine("Sau khi pop: ");
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}

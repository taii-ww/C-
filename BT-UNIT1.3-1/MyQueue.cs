using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._3_1
{
    internal class MyQueue
    {
        public Queue<string> q = new Queue<string>();

        public void queue()
        {
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");

            foreach(string i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}

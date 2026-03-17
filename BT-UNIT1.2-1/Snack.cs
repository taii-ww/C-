using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._2_1
{
    internal class Snack : MenuItem 
    {
        double price;
        public Snack(string name, double price) : base(name)
        {
            this.price = price;
        }

        public override void printToScreen()
        {
            Console.WriteLine(name + " | price: " + price);
        }
    }
}

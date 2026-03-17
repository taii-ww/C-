using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._2_1
{
    internal class Beverage : MenuItem
    {
        double smallSize;
        double mediumSize;
        double largeSize;

        public Beverage(string name, double s, double m, double l) : base(name)
        {
            smallSize = s;
            mediumSize = m;
            largeSize = l;
        }

        public override void printToScreen()
        {
            Console.WriteLine(name + " | Small: " + smallSize
                + "| medium: " + mediumSize + "| large: " + largeSize);
        }
    }
}

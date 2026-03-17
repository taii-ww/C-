using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle
    {
        public Point UpperLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point upperLeft, Point bottomRight)
        {
            UpperLeft = upperLeft;
            BottomRight = bottomRight;
        }

        public void Display()
        {
            Console.WriteLine("Rectangle:");
            Console.Write("Upper Left: ");
            UpperLeft.Display();

            Console.Write("Bottom Right: ");
            BottomRight.Display();
        }
    }
}

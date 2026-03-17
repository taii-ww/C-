using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point
    {
        public double X;
        public double Y;
        public PointColor Color { get; set; }

        public Point(double x, double y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public void Display()
        {
            Console.WriteLine($"Point({X}, {Y}) - Color: {Color}");
        }
    }
}

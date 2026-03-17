// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Point p1 = new Point(3, 8, PointColor.LightBlue);
Point p2 = new Point(12, 2, PointColor.Gold);

Rectangle rect = new Rectangle(p1, p2);

rect.Display();

Console.ReadLine();

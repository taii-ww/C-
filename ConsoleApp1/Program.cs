// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 12");



Console.Write("Nhập tên cần tìm: ");
string name = Console.ReadLine();

foreach (Student s in Student.list)
{
    if (s.Name == name)
    {
        Console.WriteLine("Id: " + s.Id + ", Name: " + s.Name);
    }
}


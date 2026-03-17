// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 14");



Console.Write("Nhập ID cần xóa: ");
int id = int.Parse(Console.ReadLine());

Student s = Student.list.Find(x => x.Id == id);

if (s != null)
{
    Student.list.Remove(s);
}

Console.Write("Sau khi xóa: ");
foreach (Student ss in Student.list)
{
    Console.WriteLine("Id: " + ss.Id + ", Name: " + ss.Name);
}

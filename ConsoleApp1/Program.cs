// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 11");


List<Student> list = new List<Student>();

list.Add(new Student { Id = 1, Name = "An" });
list.Add(new Student { Id = 2, Name = "Binh" });

foreach (Student s in list)
{
    Console.WriteLine("Id: " + s.Id + ", Name: " + s.Name);
}



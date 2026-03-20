
using System.Text;
using System.Linq;
using ConsoleApp1;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài");
Console.WriteLine("Lớp: 24T2");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 15");

List<int> numbers = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };

var a = numbers.Distinct();

foreach(var s in a)
{
    Console.WriteLine(s);
}



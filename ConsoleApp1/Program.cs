
using System.Text;
using System.Linq;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài");
Console.WriteLine("Lớp: 24T2");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 2");

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

var evenNumbers = numbers.Where(x => x > 5);

foreach (var n in evenNumbers)
{
    Console.WriteLine(n);
}

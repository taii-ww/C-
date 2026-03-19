
using System.Text;
using System.Linq;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài");
Console.WriteLine("Lớp: 24T2");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 7");

List<int> numbers = new List<int>() { 2, 5, 9, -1, -6, 12};

bool a = numbers.Any(x => x > 10);

if (a)
    Console.WriteLine("Có giá trị lớn hơn 10");
else
{
    Console.WriteLine("Không Có giá trị lớn hơn 10");
}


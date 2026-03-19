
using System.Text;
using System.Linq;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài");
Console.WriteLine("Lớp: 24T2");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 6");

List<int> numbers = new List<int>() { 2, 5, 9, -1, -6};

int countEven = numbers.Count(x => x % 2 == 0);

Console.WriteLine("Số phần tử chẵn là: "+countEven);


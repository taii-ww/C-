// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");


List<int> list = new List<int>();

list.Add(1);
list.Add(3);
list.Add(5);
list.Add(77);
list.Add(-4);

Console.WriteLine("Bài 1");
foreach (int x in list)
{
    Console.WriteLine(x);
}
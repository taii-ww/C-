// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 5");

/*
List<int> list = new List<int>();


Console.Write("Nhập số lượng phần tử: ");
int n = int.Parse(Console.ReadLine());


for(int i=1; i <= n; i++)
{
    Console.Write("Phần tử thứ " + i + ": ");
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}
*/


List<string> list = new List<string>() { "An", "Bình", "Thắng", "Tài" };
Console.WriteLine("Danh sách chứa các tên sau: ");
foreach(string item in list)
{
    Console.WriteLine(item);
}

Console.Write("Nhập tên cần xóa: ");
String name = Console.ReadLine();

list.Remove(name);

Console.WriteLine("Danh sách sau khi xóa: ");
foreach (string item in list)
{
    Console.WriteLine(item);
}

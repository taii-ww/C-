// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 6");

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
Console.WriteLine("Danh sách chứa các chuỗi sau: ");
foreach(string item in list)
{
    Console.WriteLine(item);
}

Console.Write("Nhập chuỗi cần kiểm tra: ");
string name = Console.ReadLine();

if (list.Contains(name))
    Console.WriteLine("Có trong danh sách");
else
    Console.WriteLine("Không có");

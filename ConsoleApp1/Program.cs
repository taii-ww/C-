// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 4");

List<int> list = new List<int>();

Console.Write("Nhập số lượng phần tử: ");
int n = int.Parse(Console.ReadLine());


for(int i=1; i <= n; i++)
{
    Console.Write("Phần tử thứ " + i + ": ");
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}

int dem = 0;
foreach(int x in list)
{
    if (x % 2 == 0)
        dem = dem + 1;
}

Console.WriteLine("Số chẵn trong danh sách là: " + dem);
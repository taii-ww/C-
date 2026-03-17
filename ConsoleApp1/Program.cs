// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 17");

List<int> list = new List<int>();

Console.Write("Nhập số lượng: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Nhập số: ");
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}

// đếm
Dictionary<int, int> dict = new Dictionary<int, int>();

foreach (int x in list)
{
    if (dict.ContainsKey(x))
        dict[x]++;
    else
        dict[x] = 1;
}

// tìm max
int maxCount = 0;
int result = list[0];

foreach (var item in dict)
{
    if (item.Value > maxCount)
    {
        maxCount = item.Value;
        result = item.Key;
    }
}

Console.WriteLine("Số xuất hiện nhiều nhất: " + result);




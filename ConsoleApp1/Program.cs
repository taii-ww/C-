// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 16");

Console.Write("Nhập chuỗi: ");
string str = Console.ReadLine();

Dictionary<char, int> dict = new Dictionary<char, int>();

foreach (char c in str)
{
    if (dict.ContainsKey(c))
        dict[c]++;
    else
        dict[c] = 1;
}

foreach (var item in dict)
{
    Console.Write(item.Key + " : " + item.Value + " ");
}




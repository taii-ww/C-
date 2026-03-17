// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài ");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 15");

Dictionary<string, string> dict = new Dictionary<string, string>();

dict.Add("hello", "xin chào");
dict.Add("book", "quyển sách");
dict.Add("dog", "con chó");

Console.Write("Nhập từ tiếng Anh: ");
string word = Console.ReadLine();

if (dict.ContainsKey(word))
{
    Console.WriteLine("Nghĩa: " + dict[word]);
}
else
{
    Console.WriteLine("Không tìm thấy");
}





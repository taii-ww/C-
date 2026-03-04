// See https://aka.ms/new-console-template for more information


using _29_1.BT1_3;
using System.Text;

String input = Class2.NhapChuoi();
String output = Class1.Xuly(input);

Console.WriteLine("Chuẩn hóa: " + output);

Console.WriteLine("Số từ trong chuỗi: " + Class3.Dem(input));

if (Class4.KiemTra(input))
    Console.WriteLine("Chuỗi đối xứng");
else Console.WriteLine("Chuỗi ko đối xứng");

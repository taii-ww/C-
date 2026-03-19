
using System.Text;
using System.Linq;
using ConsoleApp1;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Trần Đức Tài");
Console.WriteLine("Lớp: 24T2");
Console.WriteLine("Msv: 2415053122241 \n");

Console.WriteLine("Bài 12");

List<Student> students = new List<Student>()
{
    new Student{Id=1, Name ="An", Score=8},
    new Student{Id=2, Name="Binh", Score=6},
    new Student{Id=3, Name="Chi", Score=9},
    new Student{Id=4, Name="Dung", Score=7}
};

int a = students.Count(x => x.Score == 7);

Console.WriteLine("Số sinh viên đạt 7đ là: " + a);


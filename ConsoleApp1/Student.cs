using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id;
        public string Name;

        public static List<Student> list = new List<Student>()
    {
        new Student { Id = 1, Name = "An" },
        new Student { Id = 2, Name = "Binh" },
        new Student { Id = 3, Name = "Cuong" }
    };
    }
}

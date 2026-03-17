using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name;
        public double Score;

        public static List<Student> list = new List<Student>()
    {
        new Student { Name = "An", Score = 7.5 },
        new Student { Name = "Binh", Score = 9.0 },
        new Student { Name = "Cuong", Score = 8.2 }
    };

        public static void PrintMax()
        {
            double max = list[0].Score;

            foreach (Student s in list)
            {
                if (s.Score > max)
                    max = s.Score;
            }

            foreach (Student s in list)
            {
                if (s.Score == max)
                {
                    Console.WriteLine(s.Name + " - " + s.Score);
                }
            }
        }
    }
}

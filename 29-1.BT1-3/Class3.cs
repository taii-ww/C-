using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_1.BT1_3
{
    internal class Class3
    {
        public static int Dem(string input)
        {
            if (input == null)
                return 0;
            input = input.Trim();
            if (input == "")
                return 0;
            String[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}

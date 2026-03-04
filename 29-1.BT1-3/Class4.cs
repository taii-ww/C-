using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_1.BT1_3
{
    internal class Class4
    {
        public static bool KiemTra(string input)
        {
            if (input == null)
                return false;

            // Bỏ khoảng trắng
            input = input.Replace(" ", "");

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}

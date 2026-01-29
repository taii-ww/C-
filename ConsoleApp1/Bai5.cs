using System;

namespace ConsoleApp1
{
    public class Bai5
    {
        public Bai5()
        {
        }

        public static int? TimGiaTriLonNhat(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
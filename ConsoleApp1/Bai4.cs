using System;

namespace ConsoleApp1
{
    internal class Bai4
    {
        public int? TinhTongMang(int[] a)
        {
            if (a == null)
            {
                Console.WriteLine("Lỗi: mảng chưa được khởi tạo");
                return null;
            }

            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }

            return tong;
        }
    }
}

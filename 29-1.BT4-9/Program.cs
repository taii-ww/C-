using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Ho va ten: Tran Duc Tai \nMSV:2415053122241");
            Console.Write("\nbài 4, 5, 6");
            Console.Write("\nNhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Mảng rỗng hoặc không hợp lệ");
                return;
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // BAI 4
            Bai4 objTong = new Bai4();
            int? tong = objTong.TinhTongMang(arr);

            if (tong != null)
                Console.WriteLine("Tổng các phần tử = " + tong);


            // BAI 5
            Bai5 obj = new Bai5();

          
            int? max = Bai5.TimGiaTriLonNhat(arr);

            if (max == null)
                Console.WriteLine("Mảng rỗng hoặc null, không xử lý");
            else
                Console.WriteLine("Giá trị lớn nhất = " + max);


            // BAI 6
            Bai6 objDem = new Bai6();
            int soChan = objDem.DemSoChan(arr);

            Console.WriteLine("Số phần tử chẵn = " + soChan);


            // BAI 7
            Console.Write("\nbài 7");
            Console.Write("\nNhập họ tên: ");
            string hoTen = Console.ReadLine();

            Bai7 bai7 = new Bai7();
            string[] tach = bai7.TachHoTen(hoTen);

            if (tach != null)
            {
                Console.WriteLine("Các từ trong họ tên:");
                bai7.InMang(tach);
            }


            // BAI 8
            Console.Write("\nbài 8");

            Console.Write("\nNhập 1 câu: ");
            string cau = Console.ReadLine();

           
            Bai8 bai8 = new Bai8();
            string tuDaiNhat = bai8.TimTuDaiNhat(cau);

            if (tuDaiNhat != null)
                Console.WriteLine("Từ dài nhất: " + tuDaiNhat);

            //BAI 9
            Console.Write("\nbài 9");
            Console.WriteLine("\nMảng string bao gồm: \"Hello\", null, \"\", \"C#\", \" \", \"ChatGPT\" ");
            string[] mangChuoi = { "Hello", null, "", "C#", " ", "ChatGPT" };

            Bai9 bai9 = new Bai9();
            int soLuong = bai9.DemChuoiKhacNull(mangChuoi);

            Console.WriteLine("\nSố chuỗi khác null và khác rỗng = " + soLuong);


            Console.ReadKey();

        }
    }
}

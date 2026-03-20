
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

class SinhVien
{
    public int Tuoi { get; set; }
    public string Khoa { get; set; }
    public int NamHoc { get; set; }
    public double Diem { get; set; }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Trần Đức Tài");
        Console.WriteLine("Lớp: 24T2");
        Console.WriteLine("Msv: 2415053122241 \n");

        List<SinhVien> ds = new List<SinhVien>();
        Random rd = new Random();

        string[] khoas = { "CNS", "Agriculture" };

        // Tạo dữ liệu
        foreach (var khoa in khoas)
        {
            for (int i = 0; i < 10; i++)
            {
                ds.Add(new SinhVien
                {
                    Tuoi = rd.Next(18, 25),
                    Khoa = khoa,
                    NamHoc = rd.Next(1, 5),
                    Diem = Math.Round(rd.NextDouble() * 10, 2)
                });
            }
        }

        // 1. Max tuổi, Min tuổi
        int maxTuoi = ds.Max(sv => sv.Tuoi);
        int minTuoi = ds.Min(sv => sv.Tuoi);

        Console.WriteLine($"Max tuoi: {maxTuoi}, Min tuoi: {minTuoi}");

        // 2. Sinh viên khoa CNS
        var svCNS = ds.Where(sv => sv.Khoa == "CNS");

        Console.WriteLine("\nSinh vien khoa CNS:");
        foreach (var sv in svCNS)
        {
            Console.WriteLine($"{sv.Tuoi} - {sv.Diem}");
        }

        // 3. Lấy 10 sinh viên điểm cao nhất mỗi khoa
        var top10TheoKhoa = ds
            .GroupBy(sv => sv.Khoa)
            .Select(g => new
            {
                Khoa = g.Key,
                TopSV = g.OrderByDescending(sv => sv.Diem).Take(10)
            });

        Console.WriteLine("\nTop 10 sinh vien moi khoa:");
        foreach (var group in top10TheoKhoa)
        {
            Console.WriteLine($"Khoa: {group.Khoa}");
            foreach (var sv in group.TopSV)
            {
                Console.WriteLine($"Diem: {sv.Diem}");
            }
        }

        // 4. Bỏ sinh viên năm cuối (năm 4)
        var svConLai = ds.Where(sv => sv.NamHoc != 4);

        Console.WriteLine("\nDanh sach sinh vien (bo nam 4):");
        foreach (var sv in svConLai)
        {
            Console.WriteLine($"{sv.Khoa} - Nam {sv.NamHoc} - Diem {sv.Diem}");
        }
    }
}

       
using System;
using System.IO;

Console.WriteLine("Tran Duc Tai");
Console.WriteLine("msv: 2415053122241");


            Console.WriteLine("\nChuyen noi dung file thanh chu hoa trong C#:");
            Console.WriteLine("-------------------------------------------\n");
            Console.Write("Nhap ten file ban dau: ");
            string fileName = Console.ReadLine();
            Console.Write("Nhap ten file 2: ");
            string fileName1 = Console.ReadLine();
            if (File.Exists(fileName))
            {
                StreamReader fileRw = File.OpenText(fileName);
                StreamWriter fileWr = File.CreateText(fileName1);
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                        fileWr.WriteLine(line.ToUpper());
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
            }

Console.WriteLine("------------- ");
Console.Write("Data conversion successful !! ");
Console.ReadKey();
  
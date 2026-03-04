using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _29_1.BT1_3
{
    internal class Class1
    {
       
            public static string Xuly(String input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return "Lỗi: Chuỗi rỗng hoặc null!";
                }

                input = input.Trim();
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i< words.Length; i++)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
                }
                return string.Join(" ", words);
            }
        
    }
}

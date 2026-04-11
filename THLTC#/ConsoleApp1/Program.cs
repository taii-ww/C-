// See https://aka.ms/new-console-template for more information
Console.WriteLine("TRAN DUC TAI");
Console.WriteLine("MSV: 2415053122241");



static int CountSpaces(string str)
{
    int count = 0;

    foreach (char c in str)
    {
        if (c == ' ')
            count++;
    }

    return count;
}

// nhập từ bàn phím
Console.Write("Nhap chuoi: ");
string input = Console.ReadLine();

Console.WriteLine("So khoang trang: " + CountSpaces(input));
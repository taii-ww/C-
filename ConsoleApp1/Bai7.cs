using System;

public class Bai7
{
    public string[] TachHoTen(string hoTen)
    {
        if (hoTen == null)
            return null;

        hoTen = hoTen.Trim();
        if (hoTen == "")
            return null;

        return hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    public void InMang(string[] arr)
    {
        if (arr == null)
            return;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}


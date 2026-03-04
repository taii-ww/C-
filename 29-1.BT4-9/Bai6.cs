using System;

public class Bai6
{
    public int DemSoChan(int[] arr)
    {
        // Nếu mảng null → trả về 0
        if (arr == null)
            return 0;

        int dem = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                dem++;
        }

        return dem;
    }
}


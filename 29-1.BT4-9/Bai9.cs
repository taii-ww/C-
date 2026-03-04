using System;

public class Bai9
{
    public int DemChuoiKhacNull(string[] arr)
    {
        if (arr == null)
            return 0;

        int dem = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != null && arr[i] != "")
                dem++;
        }

        return dem;
    }
}

Console.WriteLine("Tran Duc Tai");
Console.WriteLine("msv:2415053122241");


int[] arr1 = new int[10];
int[] arr2 = new int[10]; // mang chua cac phan tu chan
int[] arr3 = new int[10]; // mang chua cac phan tu le
int i, j = 0, k = 0, n;


Console.Write("\nChia mang thanh mang chan, mang le trong C#:\n");
Console.Write("---------------------------------------------\n");

Console.Write("Nhap so phan tu can luu giu trong mang: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("Phan tu - {0}: ", i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

for (i = 0; i < n; i++)
{
    if (arr1[i] % 2 == 0)
    {
        arr2[j] = arr1[i];
        j++;
    }
    else
    {
        arr3[k] = arr1[i];
        k++;
    }
}

Console.Write("\nCac phan tu chan la: \n");
for (i = 0; i < j; i++)
{
    Console.Write("{0} ", arr2[i]);
}

Console.Write("\nCac phan tu le la:\n");
for (i = 0; i < k; i++)
{
    Console.Write("{0} ", arr3[i]);
}
Console.Write("\n\n");

Console.ReadKey();
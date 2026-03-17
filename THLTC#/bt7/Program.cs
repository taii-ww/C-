

    int num1, rem1;
    Console.Write("\n\n");
    Console.Write("Kiem tra chan le trong C#:\n");
    Console.Write("---------------------------------------");
    Console.Write("\n\n");
    Console.Write("Nhap mot so nguyen bat ky: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    rem1 = num1 % 2;
    if (rem1 == 0)
        Console.WriteLine("{0} la so chan.\n", num1);
    else
        Console.WriteLine("{0} la so le.\n", num1);

    Console.ReadKey();



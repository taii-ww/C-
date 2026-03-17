// See https://aka.ms/new-console-template for more information
public class MyGenericClass<T>
{
    public static void display(T[] inputArray)
    {
        foreach (T element in inputArray)
            Console.Write(element + " ");
        MyGenericClass<int> myGenericClass = new MyGenericClass<int>();
        
    }
}

using System;
class Program
{
    static void Main()
    {
        String str = "C# Programming";
        int[]arr = {1,2,3,4,5,6};
        Console.WriteLine("Roshan");
        Console.WriteLine("String: "+str);
        Console.WriteLine("Array Elements: ");
        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.ReadLine();
    }
}
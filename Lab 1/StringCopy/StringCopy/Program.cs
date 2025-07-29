using System;
namespace StringCopy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roshan");
            Console.Write("Enter a string: ");
            String original = Console.ReadLine();
            String copied = String.Copy(original);
            Console.WriteLine("Copied string: " + copied);
            Console.ReadLine();
        }
    }
}
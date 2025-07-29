using System;
namespace SmallestNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roshan");
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < b && b < c)
            
                Console.WriteLine("Smallest: " + a);
            
            else if (b < c)
                Console.WriteLine("Smallest: " + b);
            else
                Console.WriteLine("Smallest: " + c);
            Console.ReadLine();
        }
    }
}
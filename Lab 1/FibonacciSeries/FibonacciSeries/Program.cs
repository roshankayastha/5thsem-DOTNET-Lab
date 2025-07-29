using System;
namespace FibonacciSeries
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roshan");
            Console.Write("Enter number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacci Series: ");
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
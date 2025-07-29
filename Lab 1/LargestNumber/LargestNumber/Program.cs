using System;
namespace LargestNumber
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
            int largest = (a > b ? ((a > c) ? a : c) : ((b > c) ? b : c));
            Console.WriteLine("Largest Number is: "+largest);
            Console.ReadLine();
        }
    }
}
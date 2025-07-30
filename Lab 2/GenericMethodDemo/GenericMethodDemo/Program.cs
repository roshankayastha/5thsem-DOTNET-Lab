using System;
namespace GenericMethodDemo
{
    class Utility
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Utility util = new Utility();
            int x = 10, y = 30;
            Console.WriteLine("Roshan");
            Console.WriteLine($"Before swap: x={x}, y={y}");
            util.Swap<int>(ref x, ref y);
            Console.WriteLine($"After swap: x={x}, y={y}");
            Console.ReadLine();
        }
    }
}
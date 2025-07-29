using System;
namespace BitwiseShift
{
    class Program
    {
        static void Main()
        {
            int num = 8;
            Console.WriteLine("Roshan");
            Console.WriteLine("Original Number: "+num);
            Console.WriteLine("Left shift by 1: " + (num << 1));
            Console.WriteLine("Right shift by 1: " + (num >> 1));
            Console.ReadLine();
        }
    }
}
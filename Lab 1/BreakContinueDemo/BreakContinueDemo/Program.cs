using System;
namespace BreakContinueDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roshan");
            Console.WriteLine("Using Break: ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
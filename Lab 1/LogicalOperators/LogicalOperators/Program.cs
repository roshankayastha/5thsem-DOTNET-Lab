using System;
namespace LogicalOperators
{
    class Program
    {
        static void Main()
        {
            bool x=true, y=false;
            Console.WriteLine("Roshan");
            Console.WriteLine("x&&y: " + (x && y));
            Console.WriteLine("x||y: " + (x || y));
            Console.WriteLine("!x: " + (!x));
            Console.ReadLine();
        }
    }
}
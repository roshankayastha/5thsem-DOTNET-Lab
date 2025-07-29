using System;
namespace ValueDataTypeDemo
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int a = 10;
            float pi = 3.14f;
            char name = 'A';
            bool b = true;
            Console.WriteLine("Roshan");
            Console.WriteLine("===Value Data Type===");
            Console.WriteLine("Integer(a): "+a);
            Console.WriteLine("Float(pi): "+pi);
            Console.WriteLine("Character(name): "+name);
            Console.WriteLine("Boolean(b): "+b);
            Console.WriteLine("\n===Copy by Value===");
            int x = 100;
            int y = x;
            Console.WriteLine("Value of y after copying from x: " + y);
            y = 200;
            Console.WriteLine("Original x: " + x);
            Console.WriteLine("Modified y: "+y);
            Console.WriteLine("\n===Type checking===");
            object q = 3.14f;
            if(q is int)
            Console.WriteLine("q is an int");
            else if (q is float)
                Console.WriteLine("q is float");
            else
                Console.WriteLine("q is of unknown type");
            Console.ReadLine();

        }
    }
}
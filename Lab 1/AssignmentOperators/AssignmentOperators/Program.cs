using System;
namespace AssignmentOperators
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            Console.WriteLine("Roshan");
            a += 3;
            Console.WriteLine("a+=3: " + a);
            a -= 2;
            Console.WriteLine("a-=2: " + a);
            a *= 4;
            Console.WriteLine("a*=4: " + a);
            a /= 2;
            Console.WriteLine("a/=2: " + a);
            a %= 3;
            Console.WriteLine("a%=3: " + a);
            Console.ReadLine();
        }
    }
}
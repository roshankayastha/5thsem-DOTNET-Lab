using System;
namespace OperatorOverloading
{
    class Box
    {
        public int Length;
        public Box(int l)
        {
            Length = l;
        }
        public static Box operator + (Box b1, Box b2)
        { return new Box(b1.Length + b2.Length); }
        public void Show()
        {
            Console.WriteLine("Length: " + Length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(10);
            Box b2 = new Box(20);
            Box b3 = b1 + b2;
            Console.WriteLine("Roshan");
            b3.Show();
            Console.ReadLine();
        }
    }
}
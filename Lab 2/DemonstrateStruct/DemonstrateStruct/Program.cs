using System;
namespace DemonstrateStruct
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point Coordinates: ({ x},{ y})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            p1.Display();
            Point p2;
            p2.x = 5;
            p2.y = 15;
            p2.Display();
            Console.WriteLine("Roshan");
            Console.ReadLine();
        }
    }
}
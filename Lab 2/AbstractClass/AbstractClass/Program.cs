using System;
namespace AbstractClass
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roshan");
            Shape shape = new Circle();
            shape.Draw();
            Console.ReadLine();
        }
    }
}
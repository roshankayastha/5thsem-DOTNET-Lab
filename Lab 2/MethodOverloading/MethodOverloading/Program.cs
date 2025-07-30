using System;
namespace MethodOverloading
{
    class Calculator
    {
        public int Add (int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add int: " + calc.Add(2, 3));
            Console.WriteLine("Add double: " + calc.Add(2.5, 3.5));
            Console.WriteLine("Roshan");
            Console.ReadLine();
        }
    }
}
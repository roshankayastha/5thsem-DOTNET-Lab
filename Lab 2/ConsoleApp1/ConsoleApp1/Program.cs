using System;
namespace MethodOverriding
{
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
    class Dog:Animal
    {
        public override void speak()
        {
            Console.WriteLine("Dog Barks");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Animal a = new Dog();   
            a.speak();
            Console.WriteLine("Roshan");
            Console.ReadLine();
        }
    }
}
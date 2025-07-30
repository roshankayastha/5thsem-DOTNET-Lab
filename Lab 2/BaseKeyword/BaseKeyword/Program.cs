using System;
namespace BaseKeyword
{
    class Animal
    {
        public string Name;
        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Animal Constructor is called.");
        }
        public void Display()
        {
            Console.WriteLine("Animal name: "+Name);
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            Console.WriteLine("Cat constructor is called.");
        }
        public void Show()
        {
            base.Display();
            Console.WriteLine("This is a Cat.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Bobby");
            cat.Show();
            Console.WriteLine("Roshan");
            Console.ReadLine();
        }
    }
}
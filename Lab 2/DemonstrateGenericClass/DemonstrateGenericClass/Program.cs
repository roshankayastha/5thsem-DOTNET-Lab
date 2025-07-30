using System;
namespace DemonstrateGenericClass
{
    class Box<R>
    {
        private R content;
        public void Add(R item)
        {
            content = item;
        }
        public R Get()
        {
            return content;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(69);
            Console.WriteLine("Integer value: " + box.Get());
            Box<string> strbox = new Box<string>();
            strbox.Add("Hey, I'm Roshan.");
            Console.WriteLine("String Value:"+strbox.Get());
            Console.ReadLine();
        }
    }
}
using System;
namespace MethodHiding
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent show");
        }
    }
    class Child : Parent
    {
        public new void Show()
        {
            Console.WriteLine("Child show");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roshan");
            Parent p = new Parent();
            p.Show();
            Child c = new Child(); 
            c.Show();
            Parent pc = new Child();
            pc.Show();
            Console.ReadLine();
        }
    }
}
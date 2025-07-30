using System;
namespace MultiLevelInheritance
{
    class A
    {
        public void DisplayA()
        {
            Console.WriteLine("Roshan");
        }
    }
    class B : A
    {
        public void DisplayB()
        {
            Console.WriteLine("Kayastha");
        }
    }
    class C : B
    {
        public void DisplayC()
        {
            Console.WriteLine("Class D");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.DisplayA();
            obj.DisplayB();
            obj.DisplayC();
            Console.ReadLine();
        }
    }
}
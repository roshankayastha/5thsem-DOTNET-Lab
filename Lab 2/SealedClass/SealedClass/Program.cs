using System;
namespace SealedClass
{
    sealed class FinalClass{
        public void show()
    {
        Console.WriteLine("This is a sealed class.");
    }
    }
class Program
{
    static void Main(string[] args)
    {
            FinalClass obj = new FinalClass();
            obj.show();
            Console.WriteLine("Roshan");
            Console.ReadLine();
    }
}
}
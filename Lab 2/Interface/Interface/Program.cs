using System;
namespace Interface
{
    interface IPrintable
    {
        void Print();  
    }
    class Document: IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable printable = new Document();
            printable.Print();
            Console.WriteLine("Roshan");
            Console.ReadLine();
        }
    }
}
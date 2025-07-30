using System;
namespace Indexer
{
    class Sample
    {
        private int[] data = new int[5];
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample S = new Sample();
            S[0] = 69;
            Console.WriteLine("Roshan");
            Console.WriteLine("Value at index O: "+S[0]);
            Console.ReadLine();
        }
    }
}
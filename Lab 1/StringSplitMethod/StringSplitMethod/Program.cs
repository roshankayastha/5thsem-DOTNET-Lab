using System;
namespace StringSplitMethod
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            String sentence = Console.ReadLine();
            String[]words = sentence.Split(' ');
            Console.WriteLine("Words in the sentence: ");
            foreach(String word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
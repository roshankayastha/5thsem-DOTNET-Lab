using System;
namespace ArrayAsParameter
{
    class Program
    {
        static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Roshan");
            Console.WriteLine("Array Elements: ");
            foreach(int i in arr){
                Console.Write(i + " ");
            }
        }
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40 };
            DisplayArray(numbers);
            Console.ReadLine();
        }
    } 
}
using System;
namespace DemonstrateEnum
{
    enum Weekday
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Weekday today = Weekday.Friday;
            Console.WriteLine("Today is: " + today);
            Console.WriteLine("Integer value of " + today + "is " + (int)today);
            Console.WriteLine("\nAll Days is Enum: ");
            foreach (Weekday day in Enum.GetValues(typeof(Weekday))) {
                Console.WriteLine($"{day}= {(int)day}");
            }
            Console.WriteLine("Roshan");
            Console.ReadLine();
        }
    } }
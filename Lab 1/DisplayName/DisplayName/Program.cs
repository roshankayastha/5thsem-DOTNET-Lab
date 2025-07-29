using System;
namespace DisplayName
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Roshan");
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            String name = Console.ReadLine();
            Console.Write("Enter Address: ");
            String address = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n---Employee Details---");
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Salary: " + salary);
            Console.ReadLine();
        }
    }
}
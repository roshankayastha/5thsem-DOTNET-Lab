using System;
namespace AutoProperties
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Id = 1, Name = "Roshan",Age = 18};
            Console.WriteLine($"ID: {p.Id},Name: {p.Name},Age: {p.Age}");
            Console.ReadLine();
        }
    }
}
using System;
namespace ParameterizedConstructor
{
    class Student
    {
        string name;
        int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {name},Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Roshan", 18);
            s.Display();
            Console.ReadLine();
        }
    }
}
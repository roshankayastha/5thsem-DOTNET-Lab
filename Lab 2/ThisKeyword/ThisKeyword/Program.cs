using System;
namespace ThisKeyword
{
    class Employee
    {
        string name;
        public Employee(string name)
        {
            { this.name = name; }
        }
        public void Show()
        {
            Console.WriteLine("Employee Name: " + this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Roshan");
            emp.Show();
            Console.ReadLine();
        }
    }
}
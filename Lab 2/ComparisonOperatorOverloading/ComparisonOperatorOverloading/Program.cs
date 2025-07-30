using System;
namespace ComparisonOperatorOverloading
{
    class Student
    {
        public int Marks;
        public static bool operator > (Student S1, Student S2)
        {
            return S1.Marks > S2.Marks;
        }
        public static bool operator < (Student S1, Student S2)
        {
            return (S1.Marks < S2.Marks);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Student S1 = new Student() { Marks = 85 };
            Student S2 = new Student() { Marks = 65 };
            Console.WriteLine("Roshan");
            Console.WriteLine(S1 > S2 ? "Student 1 scored more than Student 2" : "Student 2 scored more than student 1");
            Console.ReadLine();
        }
    }
}
using System;
namespace GradeSwtichCase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roshan");
            Console.Write("Enther the marks(0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            string grade;
            switch (marks / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                case 5:
                    grade = "E";
                    break;
                default:
                    grade="F";
                    break;
            }
            Console.WriteLine("Grade: " + grade);
            Console.ReadLine();
        }
    }
}
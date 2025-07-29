using System;
namespace DiagonalMatrixSum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roshan");
            int[,] matrix =
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9},
            };
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum+= matrix[i,i];
            }
            Console.WriteLine("Sum of diagonal elmentes: "+sum);
            Console.ReadLine();
        }
        }
    }

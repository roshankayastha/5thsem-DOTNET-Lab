﻿using System;
namespace MatrixMultiplication
{
    class Program
    {
        static void Main()
        {
            int[,] A = { { 1, 2 }, { 3, 4 } };
            int[,] B = { { 5,6 }, { 7,8 } };
            int[,] C = new int[2, 2];
            Console.WriteLine("Roshan");
            for(int i = 0; i<2 ; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            Console.WriteLine("Matrix Multiplication");
            for(int i =0; i<2 ; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write((C[i, j]) + "\t"); 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
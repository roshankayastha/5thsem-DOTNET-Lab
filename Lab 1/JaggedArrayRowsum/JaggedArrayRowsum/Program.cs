﻿using System;
namespace JaggedArrayRowsum
{
    class Program
    {
        static void Main()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4,5 };
            jagged[2] = new int[] {6};
            Console.WriteLine("Roshan");
            for(int i = 0; i < jagged.Length; i++)
            {
                int sum = 0;
                Console.Write("Row" + i + " : ");
                for(int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]+" ");
                    sum+=jagged[i][j];
                }
                Console.WriteLine("=> Sum: "+sum);
            }
            Console.ReadLine();
        }
    }
}
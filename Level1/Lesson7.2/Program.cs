using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    class Program
    {
        //func
        static int Sum(int one, int two)
        {
            return one + two;
        }

        //proc
        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void PrintMatrix(byte[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static byte[,] InitMatrix(byte[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (byte)(i * j);
                }
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            byte[,] mat = new byte[20, 12];
            
            mat = InitMatrix(mat);
            PrintMatrix(mat);
            
            mat[1, 7] = 0;
            PrintMatrix(mat);

            int x = 7;
            int y = 9;
            int sum = Sum(x, y);

            Print(sum.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    class Program
    {
        static bool Task14(int n)
        {
            int sum = 0;
            int res = n;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum * 2 == res)                                   //chi ashxatum
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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

            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            bool isDoubleSum = Task14(n);

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

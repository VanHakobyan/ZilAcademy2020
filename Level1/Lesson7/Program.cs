using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,,] arr = new byte[4, 6, 9];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = (byte)(i + j + k);
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 80));
            //Jagged array

            byte[][] jaggedArray = new byte[3][];
            jaggedArray[0] = new byte[] { 53, 23, 2, 2 };
            jaggedArray[1] = new byte[] { 54, 13 };
            jaggedArray[2] = new byte[] { 4, 3, 8 };

            for (int j = 0; j < jaggedArray.Length; j++)
            {
                for (int k = 0; k < jaggedArray[j].Length; k++)
                {
                    Console.Write($"{jaggedArray[j][k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

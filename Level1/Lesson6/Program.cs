using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];

            for (int i = 0; i < 100; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Index[{i}], value={array[i]}");
            }

        }
    }
}

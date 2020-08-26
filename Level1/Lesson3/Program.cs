using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;

            bool res = (byte)(b + 1) < b;
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            byte b1 = byte.Parse(text);
            byte b = Convert.ToByte(text);

            bool res = (byte)(b + 1) < b;
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

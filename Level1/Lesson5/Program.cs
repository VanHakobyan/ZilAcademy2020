using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text2 = Console.ReadLine();
            if (text == null || text == string.Empty || string.IsNullOrEmpty(text2))
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                return;
            }

            //!(x&y) --> !x | !y

            int x = int.Parse(text);
            int y = int.Parse(text2);

            if (x < 9 && (x > 1 || y > 23) || !(y < 12 && x > y))//x=5,y=7
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            Console.ReadKey();
        }
    }
}

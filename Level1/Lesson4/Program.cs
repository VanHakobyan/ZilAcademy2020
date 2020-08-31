using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = 0.000000006m;
            decimal f = 0.000000006m;

            bool b = n1 != f;

            var result = n1 == f;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

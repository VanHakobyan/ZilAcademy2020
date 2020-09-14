using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = new int();
            Console.WriteLine(x);

            Soldier soldier1 = new Soldier(180f, 70f, 50);
            Soldier soldier2 = new Soldier(180f, 70f, 50);

            var height = soldier1.GetHeight();
            Console.WriteLine(height);
        }
    }
}

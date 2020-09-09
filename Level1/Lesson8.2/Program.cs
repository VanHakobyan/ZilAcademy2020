using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human robert = new Human("Robert", 50);
            Human karen = new Human("Karen", 40);

            var sayHello = robert.SayHello();
            Console.WriteLine(sayHello);
            Console.WriteLine(robert.ProvideInformation());

        }
    }
}

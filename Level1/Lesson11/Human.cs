using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Human
    {
        private string _name;

        public Human(string name)
        {
            _name = name;
        }


        public virtual void SayHello()
        {
            Console.WriteLine("Hello. (Human) !!!");
        }
    }
}

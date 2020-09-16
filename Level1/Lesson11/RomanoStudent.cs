using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class RomanoStudent : YsuStudent
    {
        public RomanoStudent(string name) : base(name)
        {
        }

        public void AboutMe()
        {
            Console.WriteLine("I'm best student !!!");
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello (Romano)");
            base.SayHello();
        }
    }
}

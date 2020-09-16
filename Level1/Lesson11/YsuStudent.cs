using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class YsuStudent : Student
    {
        public YsuStudent(string name) : base(name)
        {
        }

        public void YsuInformation()
        {
            Console.WriteLine("I'm YSU student !!!");
        }
    }
}

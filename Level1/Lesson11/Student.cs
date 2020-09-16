using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Student : Human
    {
        public Student(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello. (Student) !!!");
        }
    }
}

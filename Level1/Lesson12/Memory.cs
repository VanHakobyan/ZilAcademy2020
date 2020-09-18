using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    public class Memory
    {
        private string _name;
        private int _age;

        public Memory(string name)
        {
            _name = name;
        }

        public Memory(string name, int age) : this(name)
        {
            _age = age;
        }
    }
}

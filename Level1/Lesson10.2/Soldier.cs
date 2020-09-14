using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{

    public struct Home
    {
        static Home()
        {

        }

    }


    /// <summary>
    /// Derived class
    /// </summary>
    public class Soldier : Human
    {
        static Soldier()
        {

        }

        private int _d;
        public Soldier(float height, float weight, int d) : base(height, weight)
        {
            _d = d;
        }

        public float GetHeight()
        {
            return Height;
        }

    }
}

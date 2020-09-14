using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Human
    {
        static Human()
        {

        }

        public Human(float height, float weight)
        {
            Height = height;
            Weight = weight;
        }

        protected float Height;
        protected float Weight;

        public void Move()
        {

        }
    }
}

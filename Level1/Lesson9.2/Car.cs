using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._2
{
    public class Car
    {
        private ushort _maxSpeed;
        private string _color;
        private string _class;

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        private string _engineType;
        private string _model;

        public Car(string engineType, ushort maxSpeed,
            string color, string @class)
        {
            _engineType = engineType;
            _maxSpeed = maxSpeed;
            _color = color;
            _class = @class;
        }

        public int Move(byte transmission)
        {
            int speed = MoveLogic(transmission);
            return speed;
        }

        public bool IsStopped(int speed)
        {
            return speed == 0;
        }

        private int MoveLogic(byte transmission)
        {
            if (transmission == 1)
            {
                return 30;
            }
            if (transmission == 2)
            {
                return 60;
            }
            if (transmission == 3)
            {
                return 80;
            }
            if (transmission == 4)
            {
                return 130;
            }
            if (transmission == 4)
            {
                return 200;
            }

            return 0;
        }

        public string GetEngineType()
        {
            return _engineType;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age; 
            age = 24;

            string firstName = "Robert";
            string lastName = "Kocharyan";

            string text = "My name is " + firstName + " " + lastName + " Age " + age;

            byte number1 = 34;
            byte number2 = 25;

            short number3 = 124;
            short number4 = 1241;

            int sumShort = number3 + number4;
            int sum = number1 + number2;


            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}

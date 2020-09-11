using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson9._2;


namespace Lessson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("8 cylinder", 300, "BMW", "White");
            bmw.Model = "3 series";//set

            Console.WriteLine(bmw.Model);//get


            string engineType = bmw.GetEngineType();

            Console.WriteLine(engineType);

            var isStopped = bmw.IsStopped(50);
            Console.WriteLine($"Car is stopped: {isStopped}");
        }
    }
}

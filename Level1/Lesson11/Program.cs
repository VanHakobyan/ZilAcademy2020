using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Table.K;


            Student student = new Student("Karen");
            student.SayHello();

            Human st = (Human)student;
            //Human st = student as Human;

            st.SayHello();


            student = (Student)st;
            student.SayHello();

            Console.WriteLine(new string('-', 100));

            Human romanoStudent = new RomanoStudent("Anna");

            romanoStudent.SayHello();


            Console.WriteLine(new string('-', 100));

            Human[] arr = new Human[3];

            arr[0] = student;
            arr[1] = st;
            arr[2] = romanoStudent;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].SayHello();
            }


            Console.ReadKey();

        }
    }
}

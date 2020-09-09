using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {

        static int Sum()
        {
            return 0;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            var sum = Sum(9.7, 9.8);
            return a + b;
        }


        static int Sum(ref int a, int b)
        {
            int sum = a + b;
            a = 0;
            return sum;
        }

        static double Calculate(double w, double h, double t = 36.6)
        {
            return (w * h) / t;
        }

        static int Sum(int a, params int[] c)
        {
            int sum = 0;
            sum += a;
            for (int i = 0; i < c.Length; i++)
            {
                sum += c[i];
            }

            return sum;
        }
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        public static int GetNthFibonacci_Rec(int n)//4
        {
            //
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            //bazis

            else
            {
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
            }
        }

        static void Main(string[] args)
        {
            var fibonacci = Fibonacci(400);
            var fibonacci4 = GetNthFibonacci_Rec(400);
            //1 1 2 3 5 8 13 ... 

            var d = Sum(4.5, 6.8);
            int[] arr = new[] { 13, 1413, 4 };

            int s = Sum(5, arr);
            int s1 = Sum(1, 4, 5, 6, 87, 9, 6, 5);

            var calculate = Calculate(90, 160);
            var calculate2 = Calculate(90, 160, 36.8);


            int k = 7;
            int c = 8;
            var sum = Sum(c, k);//method param. by value 
            var sumRef = Sum(ref c, k);//method param. by reference 
            Console.WriteLine(sum);// 15 15
            Console.WriteLine(c);// 7 0
        }
    }
}

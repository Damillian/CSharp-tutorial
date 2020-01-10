using System;
using System.Collections;
using System.IO;

namespace HelloWorld
{


    class Program
    {

        public delegate double PerformCalculation(double x, double y);

        public static double Addition(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            PerformCalculation getSum = Addition;
        }

    }
}

using System;

namespace HelloWorld
{
    class Program
    {
       
        static void Main(string[] args)
        {
            WriteSomething("hallo");
        }

        public static void WriteSomething(string writeThis)
        {
            Console.WriteLine(writeThis);
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

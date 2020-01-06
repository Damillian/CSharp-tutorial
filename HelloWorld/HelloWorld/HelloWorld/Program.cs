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
    }
}

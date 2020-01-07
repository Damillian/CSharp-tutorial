using System;

namespace HelloWorld
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);

            Console.WriteLine(box.FrontSurface);

            //box.DisplayInfo();
            Console.Read();
        }

    }
}

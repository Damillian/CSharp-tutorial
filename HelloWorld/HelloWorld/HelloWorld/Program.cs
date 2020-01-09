using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(12.5515);
            myArrayList.Add(78);
            myArrayList.Add("Grargh");

            myArrayList.Remove(25);
            myArrayList.RemoveAt(1);

            int sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToInt32(obj);
                }
            }

            Console.WriteLine(sum);
        }

    }
}

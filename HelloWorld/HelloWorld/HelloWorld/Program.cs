using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee karel = new Employee("Ferdinands", "Karel", 15000);
            Boss hendrik = new Boss("Hazelaar", "Hendrik", 35000, "Lexus");
            Trainee pietje = new Trainee("van de Mortel", "Pietje", 0, 16, 24);

            hendrik.Lead();
            pietje.Work();
        }

    }
}

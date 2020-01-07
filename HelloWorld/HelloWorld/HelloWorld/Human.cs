using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Human
    {

        public string firstName;
        public string lastName;

        //constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName; 
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}

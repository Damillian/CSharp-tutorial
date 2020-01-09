using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public void Lead()
        {
            Console.WriteLine("{0} {1} is telling his employees what to do all day. Then he drives off in his {2}", FirstName, Name, CompanyCar);
        }

        public Boss() { }

        public Boss(string name, string firstName, int salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }
    }
}

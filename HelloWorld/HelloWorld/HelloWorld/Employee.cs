using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }

        public virtual void Work()
        {

        }

        public void Pause()
        {

        }

        public Employee() { }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
    }
}

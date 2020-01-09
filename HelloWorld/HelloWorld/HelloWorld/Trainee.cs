using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public void Learn()
        {

        }

        public Trainee() { }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public override void Work()
        {
            Console.WriteLine("{0} {1} is working for {2} hours this week", FirstName, Name, WorkingHours);
        }
    }
}

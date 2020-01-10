using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a radius of {Radius}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interface;

namespace Interfaces.Figures
{
    public class Circle : IShape
    {
        private double radius;

        const double pi = 3.14;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Name { get; set; }

        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }
        public double Square()
        {
            //S = pi*pow(r)
            double square = pi * Math.Pow(Radius,2);

            return square;
        }


        public void Display()
        {
            Console.WriteLine($"Figure - {Name}, Square - {(Square())}");
        }


    }
}

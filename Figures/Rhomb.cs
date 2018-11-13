using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interface;

namespace Interfaces.Figures
{
    public class Rhomb : IShape
    {
        private double firstside;
        private double secondside;

        public string Name { get; set; }

        public double FirstSide
        {
            get { return firstside; }
            set { firstside = value; }
        }
        public double SecondSide
        {
            get { return secondside; }
            set { secondside = value; }
        }

        public Rhomb() { }

        public Rhomb(string name, double first, double second)
        {
            Name = name;
            FirstSide = first;
            SecondSide = second; 
        }
        public double Square()
        {
            double square = (1/2.0) * FirstSide * SecondSide;

            return square;

        }

        public void Display()
        {
            Console.WriteLine($"Figure - {Name}, Square - {(Square())}");
        }

    }
}

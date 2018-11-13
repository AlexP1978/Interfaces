using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Figures;
using Interfaces.Interface;



namespace Interfaces
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangles triangle1 = new Triangles("Triangle1", 5, 6);
            triangle1.Display();

            IShape triangle2 = new CornersTriangle("Triange2",7,8.7,45);
            triangle2.Display();


            CornersTriangle triangle3 = (CornersTriangle)triangle2;
            triangle3.Name = "Triangle3";
            triangle3.Corner = 63;
            triangle3.Display();

            HeronaTriangle htr = new HeronaTriangle("Triangle4", 8, 9, 4);
            htr.Display();

            Circle circle = new Circle("Circle", 6);
            circle.Display();

            Rhomb rm = new Rhomb("Rhomb", 23, 34);
            rm.Display();

            IShape rm2 = new Rhomb{ Name = "Rhomb1", FirstSide = 12, SecondSide = 12 };


            Console.Read();

        }
    }
}

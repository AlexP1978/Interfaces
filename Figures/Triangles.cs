using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interface;
using static System.Console;

namespace Interfaces.Figures
{
    public class Triangles : IShape
    {
        private double height;
        private double width;
        //private string name;
        public string Name { get; set; }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Triangles(string name, double height, double width)
        {
            Name = name;
            Height = height;
            Width = width;
        }
        /// <summary>
        /// area calculation formula
        /// square of triangle
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            //s = 1/2 *a*h
            double square = (1/2.0)*Width*Height;

            return square;
        }

        public void Display()
        {
            WriteLine($"Figure - {Name}, Square - {(Square())}");
        }

    }

    public class HeronaTriangle : Triangles
    {
        private double thirdside;
        public double Thirdside
        {
            get { return thirdside; }
            set { thirdside = value; }
        }

        public HeronaTriangle(string name, double height, double width, double thirdside):base(name, height, width)
        {
            Thirdside = thirdside;
        }

        /// <summary>
        /// area calculation formula
        /// square of triangle 
        /// </summary>
        /// <returns></returns>
        public new double Square()
        {
            //p = 1/2*(a+b+c)
            double p = (1/2.0)*(Width + Height + Thirdside);
            //s = sqrt(p (p−a) (p−b) (p−c))
            double square = Math.Sqrt(p*(p - Width)*(p - Height)*(p - Thirdside));

            return square;
        }
    }

    public class CornersTriangle : Triangles
    {
        private double corner;
        public double Corner
        {
            get { return corner; }
            set { corner = value; }
        }

        public CornersTriangle(string name, double height, double width, double corner):base(name, height, width)
        {
            Corner = corner;
        }

        /// <summary>
        /// area calculation formula
        /// square of triangle for corners
        /// </summary>
        /// <returns></returns>
        public new double Square()
        {
            //S=1/2·a·b·sin(γ)
            double square = (1/2.0) * Height * Width * Math.Sin(Corner);

            return square;
        }
    }
}

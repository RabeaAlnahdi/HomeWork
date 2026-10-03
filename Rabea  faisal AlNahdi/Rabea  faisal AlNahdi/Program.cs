using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabea__faisal_AlNahdi
{
    //Shape Area
    class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

    }

    class Circle : Shape
    {
        public double Raduis { get; set; }
        public Circle(double raduis)
        {
            Raduis = raduis;
        }

        public override double CalculateArea()
        {
            return 3.14 * (Raduis * Raduis);
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;

        }
        public override double CalculateArea()
        {
            return Width * Height;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>
            {
                new Circle(10),
                new Rectangle(8,4)
            };

            foreach (Shape shape in Shapes)
            {
                Console.WriteLine($"RunTime : {shape.GetType()}");
                Console.WriteLine($"Area : {shape.CalculateArea()} \n ");

            }


        }
    }
}

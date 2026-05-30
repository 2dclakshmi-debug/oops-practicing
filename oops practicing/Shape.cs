using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle:Shape
    {
        public double radious;
        public Circle(double radious)
        {
            this.radious = radious;
        }
        public override double CalculateArea()
        {
            return 3.14 * radious * radious;
        }
    }
    class Rectangle:Shape
    {
        public double length;
        public double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
    class calculation
    {
        //static void Main(string[] args)
        //{
        //    Shape sh = new Circle(4);
        //   Console.WriteLine( "area of circle : "+sh.CalculateArea());
        //    sh = new Rectangle(10, 4);
        //    Console.WriteLine("area of rectangle : "+sh.CalculateArea());
        //}
    }
}

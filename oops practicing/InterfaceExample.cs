using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    interface IShape
    {
        void Area();
        double Perimeter();
    }
    class Circles : IShape 
    {
       public double Radious { get; set; }
        public void Area()
        {
            Console.WriteLine("Area of Circle is :" + (3.14 * Radious * Radious));
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radious;
        }
    }
    class Rectangles:IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public void Area ()
        {
            Console.WriteLine("Area of Rectangle is :"+(Length * Width));
        }
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }

    internal class InterfaceExample
    {
        //static void Main(string[] args)
        //{
        //    IShape circle = new Circles { Radious = 5 };
        //    circle.Area();
        //    Console.WriteLine("Perimeter of circle : " + (circle.Perimeter()));
        //    IShape rct = new Rectangles { Length = 3, Width=7};
        //    rct.Area();
        //    Console.WriteLine("Perimeter of circle : " + (rct.Perimeter()));
        //}
    }
}

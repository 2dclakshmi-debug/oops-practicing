using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class Shaape
    {
        public abstract double CalculateArea();
    }
    class Cirrcle:Shaape
    {
        public double radious;
        public Cirrcle(double radious)
        {
            this.radious = radious;
        }
        public override double CalculateArea()
        {
            return 3.14* radious*radious;
        }
    }
    class Rectanglee:Shaape
    {
        public double length;
        public double width;
        public Rectanglee(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length*width;
        }
    }
    internal class Class1
    {
        //static void Main(string[] args)
        //{
        //    Shaape sh = new Cirrcle(4);
        //    sh.CalculateArea();
        //    Console.WriteLine(sh.CalculateArea());
        //    Console.ReadLine();
        //    sh = new Rectanglee(10,4);
        //    sh.CalculateArea();
        //    Console.WriteLine(sh.CalculateArea());
        //}
    }
}

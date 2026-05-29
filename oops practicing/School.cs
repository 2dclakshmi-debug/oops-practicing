using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class Persons
    {
        protected string Name;
        private int Age;
        public Persons(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Persons constructor is calling");
        }
        public void Display()
        {
            Console.WriteLine($"name : {Name}   age :  {Age}");
        }
        public abstract void Roll();
    }
    class Students:Persons
    {
         long rolnumber;

        public Students(string name, int age, long rolnumber) : base(name, age)
        {
            this.rolnumber = rolnumber;
            Console.WriteLine("Student constructor is calling");
        }
        public override void Roll()
        {
            Console.WriteLine("Iam a Student");
        }
        
    }
  

    internal class School
    {
        //static void Main(string[] args)
        //{
        //    Students s = new Students("Ravi", 23, 45);
        //    s.Display();
        //    s.Roll();
        //}

    }
}

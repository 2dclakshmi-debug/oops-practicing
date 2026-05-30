using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class student
    {
        public int id;
        public string name;
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Student id : " + id);
            Console.WriteLine("student name : " + name);
        }
        public abstract void Roll();

    }
    internal class implementingAbstraction:student
    {
        int rollnum;
        public implementingAbstraction(int id,string name,int rollnum):base(id,name)
        {
            this.rollnum = rollnum;
            Console.WriteLine("Roll number : "+rollnum);
        }
        public override void Roll()
        {
            Console.WriteLine("Iam a Student");
        }
    }
    class Display
    {
        //static void Main(string[] args)
        //{
        //    implementingAbstraction ab = new implementingAbstraction(1, "Rani", 12);
        //    ab.Roll();
        //    ab.display();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class Personss
    {
        protected int Id { get; set; }
        private string Name { get; set; }
        public Personss(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("Person is calling");
        }
        public Personss() { }
        public void Display()
        {
            Console.WriteLine($"student id : {Id}  Student name : {Name}");
        }
        public abstract void Roll();
    }
    abstract class Studentss:Personss
    {
        protected int rollnum;
        public Studentss(int id,string name,int rollnum):base(id,name)
        {
            this.rollnum = rollnum;
            Console.WriteLine("Students is calling ");
        }
        public void Displayroll()
        {
            Console.WriteLine($"RollNumber  : {rollnum}");
        }
        public abstract void StudyType();
    }
    class Teacherss:Studentss
    {
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public Teacherss(int id,string name,int rollnum,string subject):base(id,name,rollnum)
        {
            this.subject = subject;
            Console.WriteLine("Teacher is calling");
        }

        public void Displaysubject()
        {
            Console.WriteLine(subject);
        }
        public override void Roll()
        {
            Console.WriteLine("Iam a Student");
        }
        public override void StudyType()
        {
            Console.WriteLine("Session");
        }

    }
    internal class Task

    {
        //static void Main(string[] args)
        //{
        //    Teacherss t = new Teacherss(12, "Raju", 11, "Chemistry");
        //    t.Displayroll();
        //    t.Displaysubject();
        //    t.StudyType();
        //    t.Roll();
        //    t.Display();
        //}
    }
}

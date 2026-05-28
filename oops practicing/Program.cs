
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class Person
    {
        public string name;
        public int age;
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("name is :" + name);
            Console.WriteLine("Age is :"+age);
        }
        public abstract void Roll();
    }
    class Student:Person
    {
        private long rollNumber;
        public long RollNumber
        {
            get
            {
                return RollNumber;

            }
            set
            {
                RollNumber = value;
            }
        }
            
        
        public Student(string name,int age,long RollNumber):base(name,age)
        {
            this.rollNumber = RollNumber;
        }
        public void study()
        {
            Console.WriteLine("Student is studying");
        }
        public override void Roll()
        {
            Console.WriteLine("this is overriden mehod");
        }
    }
    class Teacher : Person
    {
        public string subject;
        public Teacher(string subject)
        {
            this.subject = subject;
        }
        public void Teaching()
        {
            Console.WriteLine("Teacher teaching the subject");
        }
        public override void Roll()
        {
            Console.WriteLine("This is overridden method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("---------------");
            Console.WriteLine("Enter student name :");
            string name=Console.ReadLine();
            Console.WriteLine("Enter student age :");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter RollNumber :");
            long roll=long.Parse(Console.ReadLine());   
            Person p = new Student(name,age,roll);
            p.Display();
            p.Roll();
            Student s = (Student)p;
            s.study();

            Console.WriteLine("Teacher Details");
            Console.WriteLine("---------------");
            
            Console.WriteLine("Enter Subject :");
            string sub = Console.ReadLine();

            p = new Teacher(sub);
            p.Display();
            p.Roll();
            Teacher t= (Teacher)p;
            t.Teaching();
        }
    }
}

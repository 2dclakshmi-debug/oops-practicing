using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    class students
    {
        int stdid;
        string stdname;
        int age;
        public students(int stdid, string stdname, int age)
        {
            this.stdid = stdid;
            this.stdname = stdname;
            this.age = age;
        }
        public students(int stdid, string stdname)
        {
            this.stdid = stdid;
            this.stdname = stdname;
            

        }
        public students(string stdname, int age)
        {
            this.stdname = stdname;
            this.age = age;
        
        }
        public void display()
        {
            Console.WriteLine("Student id : " + stdid);
            Console.WriteLine("Student name : " + stdname);
            Console.WriteLine("Student age : " + age);
        }
    }
    internal class constructorOverLoadingProving
    {
        //static void Main(string[] args)
        //{
        //    students st = new students(1, "Rani");
        //    st.display();
        //    students st1 = new students(1, "ravi", 23);
        //    st1.display();
        //    students st2 = new students("Raju", 22);
        //    st2.display();
        //}
    }
}

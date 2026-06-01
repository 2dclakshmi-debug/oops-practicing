using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
     class EBMembers
    {
        public void printMessage() => Console.WriteLine("Hello,World");
        public int Square(int x) => x * x;
        public EBMembers() => Console.WriteLine("Constructor is called");
    }

    internal class Class2
    {
        //static void Main(string[] args)
        //{
        //    EBMembers emb = new EBMembers();
        //    emb.printMessage();
        //    Console.WriteLine(emb.Square(10));
        //}
    }
}

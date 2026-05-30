using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    internal class ProveStaticVariable
    {
       static int staticCount;
        int instanceCount;
        public void calculateCount()
        {
            int localCount = 0; 
           staticCount++;
            instanceCount++;
            localCount++;
            Console.WriteLine("static count is :" + staticCount);
            Console.WriteLine("instance count is :" + instanceCount);
            Console.WriteLine("local count is :"+localCount);

        }
    }
    class Calculation
    {
        //static void Main(string[] args)
        //{
        //    ProveStaticVariable st=new ProveStaticVariable();
        //    st.calculateCount();
        //    st.calculateCount();
        //    ProveStaticVariable st1 = new ProveStaticVariable();
        //    st1.calculateCount();
        //    st1.calculateCount();
        //    ProveStaticVariable st2 = new ProveStaticVariable();
        //    st2.calculateCount();
        //    st2 .calculateCount();
        //}
    }


}

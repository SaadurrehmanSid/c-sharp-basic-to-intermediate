using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    public delegate void MulticastDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //MulticastDelegate md,md2,md3,md4;
            //md = Method1;
            //md2 = Method2;
            //md3 = Method3;

            //md4 = md + md2 + md3 - md2;
            //md4();


            //// Second way to do this/////
            ///

            MulticastDelegate md = new MulticastDelegate(Method1);
            md += Method2;
            md += Method3;

            md();
        }

        public static void Method1()
        {
            Console.WriteLine("this is method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("this is method 2");
        }

        public static void Method3()
        {
            Console.WriteLine("this is method 3");
        }
    }


}

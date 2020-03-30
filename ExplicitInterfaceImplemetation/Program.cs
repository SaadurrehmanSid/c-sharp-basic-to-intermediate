using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplemetation
{
    class Program : I1,I2
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            ///way one to call them 
            ///By type casting
            ///

            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();


            ////way two 
            ///by creating a object of interface which points to the child class object
            ///
            Console.WriteLine("-----------------------------------------------");
            I1 i1 = new Program();
            I2 i2 = new Program();

            i1.InterfaceMethod();
            i2.InterfaceMethod();


        }

        void  I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
    }


    interface I1 {

        void InterfaceMethod();
    }

    interface  I2
    {
        void InterfaceMethod();
    }
}

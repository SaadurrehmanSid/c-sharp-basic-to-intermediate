using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClassInhertitanceUsingInterfaces
{
    interface IA {

        void Aprint();
    }
    interface IB
    {

        void Bprint();
    }

    class A : IA
    {
        public void Aprint()
        {
            Console.WriteLine("CLass  A prit method");
        }
    }

    class B : IB
    {
        public void Bprint()
        {
            Console.WriteLine("CLass B prit method");
        }
    }


    class AB : IB,IA
    {

        IA a = new A();
        IB b = new B();
        public void Aprint()
        {
            a.Aprint();
        }

        public void Bprint()
        {
            b.Bprint();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();

            ab.Aprint();
            ab.Bprint();
        }
    }
}

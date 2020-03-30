using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;


public delegate void HelloFunctionDelegate(string strMessage);

  class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate hf = new HelloFunctionDelegate(Hello);
            hf("this is a hello message");
        }

        public  static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }


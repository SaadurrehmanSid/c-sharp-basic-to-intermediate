using System;
using System.Runtime.InteropServices;

namespace OptionalParametersInCShrap
{
    class Program
    {
        static void Main(string[] args)
        {

            // by specifying the parameter optional 
            add(2, 4);
            add(2, 4, new int[] { 9,9});


            // by specifying the parameter defaults
            //add(2, 4);
            //add(2, 4, new int[] { 9,9});


            /// by method overloading
            ////add(1,2);
            ////add(1,2,new int[] { 5,6,7,8,8,8});
        }

        //=======By using parameter Arrays
        //public static void add(int a, int b, params int[] restOfTheNumbers)
        //{
        //    int result = a + b;
        //    if (restOfTheNumbers != null)
        //    {
        //        foreach (var i in restOfTheNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine(result);
        //}



        ///---------------------------------------------------------------------------//
        /// by method overloading  ///////
        /// 

        //public static void add(int a, int b, int[] restOfTheNumbers)
        //{
        //    int result = a + b;
        //    if (restOfTheNumbers != null)
        //    {
        //        foreach (var i in restOfTheNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine(result);
        //}

        //public static void add(int a, int b)
        //{
        //    int result = a + b;

        //    Console.WriteLine(result);
        //}


        //---------------------------------------------------------------------------//

        ///    by specifying parameter defaults    //////

        //    public static void add(int a, int b, int[] restOfTheNumbers = null)
        //    {
        //        int result = a + b;
        //        if (restOfTheNumbers != null)
        //        {
        //            foreach (var i in restOfTheNumbers)
        //            {
        //                result += i;
        //            }
        //        }
        //        Console.WriteLine(result);
        //    }

        public static void add(int a, int b, [Optional]int[] restOfTheNumbers)
        {
            int result = a + b;
            if (restOfTheNumbers != null)
            {
                foreach (var i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }


    }
}

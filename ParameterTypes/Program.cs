using System;

namespace ParameterTypes
{
    class Program
    {
        /// <summary>
        ///There are four types of parameters
        ///Value Type
        ///Reference Type
        ///Out type
        ///parameter arrays type
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///Value type'
            int i = 0;
            int result = ParameterPassAsValueType(i);
            Console.WriteLine(i);
            Console.WriteLine(result);

            //Both the values will be different because the parameter is passed as value type

            /// Reference Type

            int a = 0;
            ParameterPassAsReferenceType(ref a);
            Console.WriteLine(a);
            Console.WriteLine(result);

            ///the out put of both variables will be same because the parameter is passed as reference type


            /// Out type
            /// 

            int sum = 0;
            int product = 0;

            ParameterPassAsOutType(7, 9, out sum, out product);
            Console.WriteLine(sum);
            Console.WriteLine(product);


            ///parameter arrays
            ///

            int[] array = new int[3];
            array[0] = 2;
            array[1] = 4;
            array[2] = 6;


            ParameterPassAsParameterArrayType(array);
            Console.WriteLine("<----------------------------------------------------------------->");
            ParameterPassAsParameterArrayType(1,2,4,5,8);
            Console.WriteLine("<----------------------------------------------------------------->");





        }

        public static int ParameterPassAsValueType(int j)
        {
            return j = 101;
        }

        public static int ParameterPassAsReferenceType(ref int j)
        {
            return j = 101;
        }


        public static void ParameterPassAsOutType(int i, int j, out int sum, out int product)
        {
            sum = i + j;
            product = i * j;
        }

        public static void ParameterPassAsParameterArrayType(params int[] numbers)
        {
            Console.WriteLine("the length of array is  {0}",numbers.Length);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

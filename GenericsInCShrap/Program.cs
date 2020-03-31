using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCShrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparision<int> comparison = new Comparision<int>();
            Console.WriteLine(comparison.match(5, 5));
            
        }
    }


   public  class Comparision<T>
    {
        public  bool match(T a, T b)
        {
            return a.Equals(b);
        }
    }
}

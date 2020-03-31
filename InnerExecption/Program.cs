using Magnum.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExecption
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            try
            {
                try
                {
                    streamReader = new StreamReader(@"C:\Users\Saad ur rehman\Downloadsssss\data.txt");
                    Console.WriteLine(streamReader.ReadToEnd());
                }
                catch (Exception ex)
                {
                    throw new FileNotFoundException( " file is not present",ex);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("thrown execption "+exception.Message);
                Console.WriteLine("Orignal Execption "+ exception.InnerException.Message);
            }

        }
    }
}

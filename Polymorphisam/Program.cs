using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[3];
            employee[0] = new Employee();
            employee[1] = new FullTimeEmplyee();
            employee[2] = new PartTimeEmplyee();

            employee[0].print();
            employee[1].print();
            employee[2].print();
        }
    }


    class Employee {

        string firstName = "fn";
        string lastName = "Ln";

        public virtual void print() 
        {
            Console.WriteLine(firstName+" "+lastName);
        }
    }

    class FullTimeEmplyee : Employee 
    {
        public override void print()
        {
            Console.WriteLine("this is a full time class mehtod");
        }
    }

    class PartTimeEmplyee : Employee
    {
        public override void print()
        {
            
            Console.WriteLine("this is a part time class  method");
        }
    }














}

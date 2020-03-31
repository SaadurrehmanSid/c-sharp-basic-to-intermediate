using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee> 
            {
                new Employee{Name="Mark",Gender = Gender.male },
                new Employee{ Name="Marry", Gender = Gender.female}
            };

            foreach (var emp in employee)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Gender);
            }

        }
    }




    public enum Gender 
    {
        unkown,
        female,
        male
    }

    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}

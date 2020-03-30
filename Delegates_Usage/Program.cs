using System;
using System.Collections.Generic;
/*---------with out delegats------------------------------------*/

//namespace Delegates_Usage
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> employees = new List<Employee>();
//            employees.Add(new Employee { Id = 1, Name = "Saad ur rehman", Experience = 6 });
//            employees.Add(new Employee { Id = 2, Name = "Saeed ur rehman", Experience = 7 });
//            employees.Add(new Employee { Id = 3, Name = "Sami ur rehman", Experience = 2 });

//            Employee emp = new Employee();
//            emp.isPromatable(employees);
//        }
//    }

//   public class Employee 
//    {
//        public int  Id { get; set; }
//        public string Name { get; set; }
//        public int Experience { get; set; }

//        public  void isPromatable(List<Employee> employees) 
//        {
//            foreach (var emp  in employees)
//            {
//                if (emp.Experience > 5)
//                {
//                    Console.WriteLine(emp.Name);
//                }
//            }
//        }
//    }
//}


/*----------with delegates------------------------------------*/

namespace Delegates_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Saad ur rehman", Experience = 6 });
            employees.Add(new Employee { Id = 2, Name = "Saeed ur rehman", Experience = 7 });
            employees.Add(new Employee { Id = 3, Name = "Sami ur rehman", Experience = 2 });

            Employee emp = new Employee();
          //  HaveExperience eligible = new HaveExperience(isEligible);
            emp.isPromatable(employees, exp => exp.Experience >5);
            //emp.isPromatable(employees, isEligible);
        }
        //public static bool isEligible(Employee employee)
        //{
        //    if (employee.Experience > 5)
        //        return true;
        //    else
        //        return false;
        //}
    }
    public delegate bool HaveExperience(Employee employee);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public void isPromatable(List<Employee> employees, HaveExperience haveExperience)
        {
            foreach (var emp in employees)
            {
                if (haveExperience(emp))
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
}
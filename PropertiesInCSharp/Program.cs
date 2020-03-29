using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.id = 102;

            s.name = "saad ur rehman";

            Console.WriteLine("{0}) Name = {1} and pass marks = {2} ",s.id,s.name,s.passMarks);
        }
    }


    class Student
    {

        private int _id;
        private string _name;
        private int _passMarks =33;

        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (id < 0)
                {
                    throw new Exception("Id cant be a negative number");
                }

                this._id = value;
            }

        }


        public string name {

            set
            {
                if (name != null)
                {
                    this._name = value;
                }
                else
                {
                    this._name = "No name";
                }
            }

            get {
                return this._name;
            }

           
        }


        public int passMarks {

            get {
                return this._passMarks;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();


            car.color("Red");
            car.Model("BMW i-8");
            car.price(150000);

        }
    }

    class Car : IVehicle
    {
        public void color(string color)
        {
            Console.WriteLine("the color of car is {0}",color);
        }

        public void Model(string model)
        {
            Console.WriteLine("the model is {0}",model);
        }

        public void price(int price)
        {
            Console.WriteLine("the price of car is {0}$",price);
        }
    }

    interface IVehicle {
        void color(string color);
        void price(int price);
        void Model(string model);
    }
}

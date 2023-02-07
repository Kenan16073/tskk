using System;
using System.Xml.Schema;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Range Rover","Vogue")
            {
                Millage = 400,
                FuelCapacity=60,
            };
            Bicycle bicycle = new Bicycle("BMX","Desna")
            {  
                Millage = 100,
            };
            car.ShowInfo();
            bicycle.ShowInfo();

            
        }
    }
}

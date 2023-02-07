using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Car:Vehicle
    {
        public Car(string brand,string model) : base(brand,model)
        {

        }
        public int FuelCapacity;
        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}-Model:{Model}-FuelCapacity:{FuelCapacity}-Millage:{Millage}");
        }
    }
}

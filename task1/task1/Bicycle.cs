using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Bicycle:Vehicle
    {
        public Bicycle(string brand,string model) : base(brand,model)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}-Model:{Model}-Millage:{Millage}");
        }


    }
}

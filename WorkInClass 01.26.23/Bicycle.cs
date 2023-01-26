using System;
using System.Collections.Generic;
using System.Text;

namespace WorkInClass_01._26._23
{
    internal class Bicycle
    {
        public string Brand;
        public string Model;
        public double Millage;

        public Bicycle(string brand, string model, double millage=0)
        {
            Brand = brand;
            Model = model;
            Millage = millage;
        }

        public void Drive(double km)
        {
            Millage += km;
        }
    }
}

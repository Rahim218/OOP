using System;
using System.Collections.Generic;
using System.Text;

namespace WorkInClass_01._26._23
{
    internal class Product
    {
        public string Name;
        public int Price;
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name} \n  Price : {Price}");
        }
    }
}

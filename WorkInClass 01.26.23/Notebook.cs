using System;
using System.Collections.Generic;
using System.Text;

namespace WorkInClass_01._26._23
{
    internal class Notebook:Product
    {
        public Notebook(string name , int price):base(name,price)
        {

        }
        public double Ram;
        public double Storage;
    }
}

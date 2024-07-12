using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int X, int Y, int Z):base(X,Y)   /*Constructor Chaining*/
        {
           this.Z = Z;
        }

        
        public new int Product()
        {
            // return X * Y * Z;
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nZ: {Z}";
        }

    }
}

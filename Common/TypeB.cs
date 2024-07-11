using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {

        //public void Test()
        //{
        //    TypeA obj = new TypeA();
        //    // obj.X = 1;   // "X is Private"
        //    // obj.Y = 5;   // "Y is Private"
        //    obj.Z = 5;      // "Z is internal"

        //}

        public TypeB()
        {
            // H can't be inherited as it is private
            // X is inherited as "Private"
            // Y is inherited as "Private"
            // Z is inherited as "internal"
        }
    }
}

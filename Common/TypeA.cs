using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        private int H;              // Can not be inherited
        private protected int X;    // Private
        protected int Y;            // Private
        internal protected int Z;   // internal
    }
}

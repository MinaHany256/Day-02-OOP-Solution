using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_Overriding

{
    class TypeA02
    {
        public int A { get; set; }

        public TypeA02(int A)
        {
            this.A = A;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }

    class TypeB02 : TypeA02
    {
        public int B { get; set; }

        public TypeB02(int B,int A):base(A) 
        {
            this.B = B;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am TypeB [Child]");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : B = {B}");
        }
    }
}

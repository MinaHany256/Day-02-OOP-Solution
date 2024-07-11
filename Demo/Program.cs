using Demo.Inheritance;
using System;
using Common;
using Demo.Polymorphism_Overriding;

namespace Demo
{
    internal class Program
    {
        #region Polymorphism => 1. Function Overloading
        public static int Sum(int X, int Y)
        {
            return X + Y;
        }

        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        #endregion


        static void Main(string[] args)
        {
            #region Class
            //Car C1;
            /// Declare for reference ot type "Car" , Refering to null
            /// CLR will Allocate 4 Bytes at STACK for this reference 'C1'
            /// CLR will Allocate 0 Bytes at HEAP 

            //C1 = new Car(123, "Kia Cerato 2024");
            //C1 = new Car(123);
            // New 
            /// 1. Allocate Required Number of Bytes for the allocated Object at HEAP = 16 Bytes
            /// 2. Intialize the Allocated Bytes of each and every Attributes with the default value of the attributes DataTypes
            /// 3. Call User-Defined Constructor [if exists]
            /// 4. Assign the address of the Allocated Object in the HEAP to the reference 'C1'
            //Console.WriteLine("*********************");
            //Console.WriteLine(C1); 
            #endregion

            #region Inheritance
            //Child C1 = new Child(1,2,3);

            //Console.WriteLine(C1.ToString());
            //Console.WriteLine("*********************");
            //Console.WriteLine($"Product = {C1.Product()}"); 
            #endregion

            #region Access Modifiers
            TypeA obj = new TypeA();
            // obj.X = 1;   // "X is Private"
            // obj.Y = 5;   // "Y is Private"
            // obj.Z = 5;   // "Z is internal" 
            #endregion

            #region Association



            #endregion

            #region Polymorphism => 1. Function Overloading
            //int Result = Sum(1, 2, 3);
            //Console.WriteLine($"Sum = {Result}");

            #endregion

            #region Polymorphism => 2. Function Overriding

            //TypeA02 TypeA = new TypeA02(1);
            //TypeA.A = 11;
            //TypeA.MyFun01();
            //TypeA.MyFun02();

            //TypeB02 TypeB = new TypeB02(1,2);
            //TypeB.A = 11;
            //TypeB.B = 22;
            //TypeB.MyFun01();
            //TypeB.MyFun02();

            #endregion

            #region What is Binding?
            // Binding
            // Binding is a Behaviour
            // Reference From Parent = Object From Child  [Binding Occurs]

            //TypeA02 RefBase = new TypeB02(1, 2);
            //RefBase.A = 11;
            //RefBase.MyFun01();
            //RefBase.MyFun02(); 
            #endregion



        }
    }
}

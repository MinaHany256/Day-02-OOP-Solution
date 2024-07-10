namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car C1;
            /// Declare for reference ot type "Car" , Refering to null
            /// CLR will Allocate 4 Bytes at STACK for this reference 'C1'
            /// CLR will Allocate 0 Bytes at HEAP 

            //C1 = new Car(123, "Kia Cerato 2024");
            C1 = new Car(123);
            // New 
            /// 1. Allocate Required Number of Bytes for the allocated Object at HEAP = 16 Bytes
            /// 2. Intialize the Allocated Bytes of each and every Attributes with the default value of the attributes DataTypes
            /// 3. Call User-Defined Constructor [if exists]
            /// 4. Assign the address of the Allocated Object in the HEAP to the reference 'C1'
            Console.WriteLine("*********************");
            Console.WriteLine(C1);
        }
    }
}

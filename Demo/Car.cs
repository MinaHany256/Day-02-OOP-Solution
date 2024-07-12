using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string? model;
        private double speed;
        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Constructors

        /// If No User-Defined Constructor Exists, Compiler will Always Generate Empty Parameterless Constructor. 
        ///public Car()
        ///{
        ///	// DO Nothing
        ///}

        /// If You Define a Constructor, Compiler will no longer generate Empty Paramterless Constructor


        public Car(int id, string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
            Console.WriteLine("Constructor 01");
        }

        public Car(int id, string? model) : this(id, model, 180)      /*Constructor Chaining*/
        {
            //this.id = id;
            //this.model = model;
            //this.speed = 180;
            Console.WriteLine("Constructor 02");
        }

        public Car(int id) : this(id, "Hyndaui ELantra 2023", 200)
        {
            //this.id = id;
            //this.model = "Hyndaui ELantra 2023";
            //this.speed = 200;
            Console.WriteLine("Constructor 03");
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Car Id: {id}\nModel: {model}\nSpeed: {speed}";
        } 
        #endregion

    }
}

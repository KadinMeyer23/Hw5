using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicals_inheritance
{
    public class Car:vehical
    {
        private int numCardoors = 0;

        public int NumCarDoors { get { return this.numCardoors; }set { this.numCardoors = value; } }

        public Car(int aNumCarDoors, string aMake, string aModel, int aYear) : base(aMake, aModel, aYear)
        {
            NumCarDoors = aNumCarDoors;
        }

        //Methods

        public override string ToString()
        {

            string message = "Make: " + Make + ", Model: " + Model + ", Year: " + Year + ", NumOfDoors: "+ NumCarDoors;
            return message;
        }

    }
}

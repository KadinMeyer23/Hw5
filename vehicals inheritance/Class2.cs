using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicals_inheritance
{
    public class Motorcycle:vehical
    {
        private bool hasSidecar = false;




        public bool HasSideCar { get { return hasSidecar; } set { this.hasSidecar = value; } }

        public Motorcycle(bool ahasSideCar, string aMake, string aModel, int aYear): base(aMake, aModel, aYear) 
        {
            HasSideCar = ahasSideCar;
        }

        //Methods

        public override string ToString()
        {

            string message = "Make: " + Make + ", Model: " + Model + ", Year: " + Year + ", HasSideCar: "+HasSideCar;
            return message;
        }
    }
}

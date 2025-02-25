using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicals_inheritance
{
    public class vehical
    {
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;




        public string Make {get{ return this.make; }set{ this.make = value; } }

        public string Model { get { return this.model; } set { this.model = value; } }

        public int Year {get{ return this.year; }set{ this.year = value; } }


        //Constructor

        public vehical(string aMake, string aModel, int aYear) {
            Make = aMake;
            Model = aModel;
            Year = aYear;
        
        }

        //Methods

        public override string ToString()
        {

            string message = "Make: " + Make + ", Model: " + Model + ", Year: " + Year;
            return message;
        }
    }
}

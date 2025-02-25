//Kadin Meyer
 //2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Inheritance
{
    public class Circle: Shape
    {
        private int radius = -1;

        public int Radius { get { return radius; } set { radius = value; } }

        public Circle(string aColor, int aRadius) : base(aColor)
        {
            Radius = aRadius;

        }

        public override double get_Area()
        {
            double Area = Math.PI * Radius * Radius;
            
            return Area;
        }

        public override string ToString()
        {
            string message = "Color: " + Color + ", Area: " + get_Area();
            return message;
        }



    }
}

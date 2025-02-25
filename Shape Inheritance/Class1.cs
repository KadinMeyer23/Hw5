//Kadin Meyer
//2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Inheritance
{
    public abstract class Shape
    {
        private string color = "n/a";

        public string Color { get { return color; } set { color = value; } }

        public Shape(string Acolor) { Color = Acolor; }

        public abstract double get_Area();

        public override string ToString() { 
            
            string Message = "Color: "+ Color;
            return Message; }
    }
}

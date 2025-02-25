//Kadin Meyer
//2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Inheritance
{
    public class Rectangle:Shape
    {
        private int width = -1;
        private int height = -1;

        public int Width { get { return this.width; } set { this.width = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }


        public Rectangle(string aColor, int aWidth, int aHeight) : base(aColor) {
            Width = aWidth;
            Height = aHeight; 
        
        }

        public override double get_Area()
        { 
            double Area = Width * Height; 
            return Area; 
        }
        public override string ToString()
        {
            string message = "Color: " + Color + ", Area: " + get_Area();
            return message;
        }
    }
}

//Kadin Meyer 2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    public class Animal
    {
        private string name = "n/a";

        public string Name {  get { return name; } set {    name = value; } }
        public Animal(string aName) { Name = aName; }

        public virtual string MakeSound() { return "Some Generic Sound"; }

        public override string ToString() { string message = "Animal: " + Name + ", Sound:" + MakeSound(); return message; }
    }
}

//Kadin Meyer 2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    public class Cat:Animal
    {
        public Cat(string aName) : base(aName) { }
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}

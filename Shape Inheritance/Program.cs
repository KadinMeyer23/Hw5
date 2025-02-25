//Kadin Meyer
//2/25/2025

namespace Shape_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle aShape1 = new Circle("Red", 5);
            Rectangle aShape2 = new Rectangle("Black", 3, 4);

            List<Shape>ListOfShapes = new List<Shape>();
            ListOfShapes.Add(aShape1);
            ListOfShapes.Add(aShape2);

            foreach(Shape a in ListOfShapes) {Console.WriteLine(a.ToString());}

        }
    }
}

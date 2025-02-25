//Kadin Meyer 2/25/2025

namespace Animal_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
           Animal aAnimal = new Animal("Chicken");
            Dog aAnimal2 = new Dog("Dog");
            Cat aAnimal3 = new Cat("Cat");

            List<Animal>ListOfAnimals = new List<Animal>();

            ListOfAnimals.Add(aAnimal);
            ListOfAnimals.Add(aAnimal2);
            ListOfAnimals.Add(aAnimal3);

            foreach(Animal a in ListOfAnimals) {Console.WriteLine(a.ToString());}
        }
    }
}

namespace vehicals_inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            vehical avehical = new vehical("Tesla","model G", 2021);
            Motorcycle avehical2 = new Motorcycle(false,"Indian","2400Hg",1997);
            Car avehical3 = new Car(4,"Ford","Flex",2014);

            List<vehical>ListOfVehicals = new List<vehical>();
            ListOfVehicals.Add(avehical);
            ListOfVehicals.Add(avehical2);
            ListOfVehicals.Add(avehical3);

            foreach (var v in ListOfVehicals) { Console.WriteLine(v.ToString()); }
            

        }
    }
}

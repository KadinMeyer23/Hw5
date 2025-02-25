//Kadin Meyer 2/25/2025

namespace Library_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book abook1 = new Book("123Abc", "Dr.Suess", 1995);
            Ebook abook2 = new Ebook("King Kong", "John Bill", 2012,12);
            PrintedBook abook3 = new PrintedBook("dinosaurs", "Ross Mccadams", 2021, 413);

            List<Book> ListOfBooks = new List<Book>();
            ListOfBooks.Add(abook1);
            ListOfBooks.Add(abook2);
            ListOfBooks.Add(abook3);

            foreach (Book book in ListOfBooks) {Console.WriteLine(book.ToString());}
        }
    }
}

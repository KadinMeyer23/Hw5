//Kadin Meyer 2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Inheritance
{
    public class Book
    {
        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = -1;


        public string Title {  get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int YearPublished { get { return yearPublished; } set { yearPublished = value; } }

        public Book(string aTitle, string aAuthor, int aYearPublished) 
        { 
            Title = aTitle;
            Author = aAuthor;
            YearPublished = aYearPublished;
        
        }

        public override string ToString() {
            string message = Title + " By " + Author + "(" + YearPublished + ")";
            return message;
        
        }
    }
}

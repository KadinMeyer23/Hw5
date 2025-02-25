//Kadin Meyer 2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Inheritance
{
    public class PrintedBook:Book
    {
        private int pageCount = -1;

        public int PageCount {  get { return this.pageCount; } set { this.pageCount = value; } }
        public PrintedBook(string aTitle, string aAuthor, int aYearPublished, int aPageCount) : base(aTitle, aAuthor, aYearPublished)
        {
            PageCount = aPageCount;
        }

        public override string ToString()
        {
            string message = Title + " By " + Author + "(" + YearPublished + ") " + ", Page Count: " + PageCount ;
            return message;

        }

    }
}

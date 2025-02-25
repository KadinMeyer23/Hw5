//Kadin Meyer 2/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Inheritance
{
    public class Ebook:Book
    {
        private int fileSizemb = 0;

        public int FileSizeMb { get { return this.fileSizemb; } set { this.fileSizemb = value; } }

        public Ebook(string aTitle, string aAuthor, int aYearPublished, int aFilesize) : base(aTitle, aAuthor, aYearPublished) 
        {
            FileSizeMb = aFilesize;
        }
        public override string ToString()
        {
            string message = Title + " By " + Author + "(" + YearPublished + ") "+ ", File Size: "+ FileSizeMb;
            return message;

        }
    }
}

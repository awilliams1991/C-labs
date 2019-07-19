using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        /*
         * 7. Book
a. title – string
b. author – string
c. numberOfPages – int
         * */

        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }//FQCTOR

        public Book() { }//default

        public override string ToString()
        {
            return string.Format($"{Title} written by {Author} is {NumberOfPages} pages long."); 
        }//end tostring

    }//end class
}//end class

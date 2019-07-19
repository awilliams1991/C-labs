using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        /*
         * 8. Library
a. books – List<Book>
b. libraryName – string
c. streetAddress – string
d. city – string
e. state – string
f. zip – string
         * */

        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }//FQCTOR

        public Library() { }//default

        public override string ToString()
        {
            string book = "";
            foreach (Book books in Books)
            {
                book += books;
            }//end foreach
            return string.Format($"{LibraryName} is located at {StreetAddress}, {City} in the state of {State} and has the zip code of {Zip}. " +
                $"You can find {book} there.\n");
        }//end tostring
    }//end class
}//end namespace

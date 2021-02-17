using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_5_8
{
    public class Library
    {
        public List<Books> Books { get; set; }
        public string LibraryName { get; set; }
        public string LibraryAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library() { }

        public Library(string libraryName, string libraryAddress, List<Books> books, string city, string state, string zip)
        {
            LibraryName = libraryName;
            LibraryAddress = libraryAddress;
            Books = books;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            string booksInStock = "";

            foreach (Books b in Books)
            {
                booksInStock += b + "\n";
            }

            return string.Format("\nLibrary Name: {0}" +
                "\nLibrary Address: {1} {3}, {4}, {5}" +
                "\nBooks Available: \n{2}", LibraryName, LibraryAddress, booksInStock, City, State, Zip);
        }
    }
}

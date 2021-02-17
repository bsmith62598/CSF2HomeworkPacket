using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_5_8
{
    public class Books
    {
        public string Author { get; set; }
        public int NbrOfPages { get; set; }
        public string Title { get; set; }

        public Books() { }
        public Books(string title, string author, int nbrOfPages)
        {
            Title = title;
            Author = author;
            NbrOfPages = nbrOfPages;
        }

        public override string ToString()
        {
            return string.Format("\nTitle: {0}" +
                "\nAuthor: {1}" +
                "\nNumber of Pages: {2}", Title, Author, NbrOfPages);
        }
    }
}

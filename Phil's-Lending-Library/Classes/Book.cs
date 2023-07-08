using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil_s_Lending_Library.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }


        public Book(string title, string firstName, string lastName, int numberOfPages)
        {
            Title = title;
            Author =firstName+" "+lastName;
            NumberOfPages = numberOfPages;
        }
    }

}


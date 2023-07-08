using Phil_s_Lending_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil_s_Lending_Library.Classes
{
    public class Library:ILibrary
    {
        private Dictionary<string, Book> books;
        public int Count => books.Count;//=> "only has getter that mean:read-only property

        public Library()
        {
            books = new Dictionary<string, Book>();
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages);
            books.Add(title, book);
        }

        public Book Borrow(string title)
        {
            if (books.TryGetValue(title, out Book bookToBorrow))
            {
                books.Remove(title);
                return bookToBorrow;
            }

            return null;
        }

        public void Return(Book book)
        {
            books.Add(book.Title, book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using Phil_s_Lending_Library.Classes;

namespace Phil_s_Lending_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Library library = new Library();
            library.Add("How To Grow More Vegetables", " J","unky", 200);

            Backpack<Book> backpack = new Backpack<Book>();
          
            Book borrowedBook = library.Borrow("How To Grow More Vegetables");
            backpack.Pack(borrowedBook);

            Book unpackedBook = backpack.Unpack(0);

            Console.WriteLine("Title: " + unpackedBook.Title);
            Console.WriteLine("Author: " + unpackedBook.Author);
            Console.WriteLine("Number of Pages: " + unpackedBook.NumberOfPages);

        }
    }
}
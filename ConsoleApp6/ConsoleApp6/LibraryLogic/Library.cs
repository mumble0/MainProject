using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.LibraryLogic
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book.IsLibrary)
            {
                books.Add(book);
            }
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void ShowBooks()
        {
            foreach (Book book in books)
            {
                System.Console.WriteLine(book.ToString());
            }
        }
    }
}

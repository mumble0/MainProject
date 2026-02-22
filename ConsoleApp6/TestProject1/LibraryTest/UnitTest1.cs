using Xunit;
using System.Collections.Generic;

namespace Tests1.Tests.LibraryTest
{
    public class Book
    {
        public string NameBook { get; set; }
        public string TypeBook { get; set; }
        public int AgeBook { get; set; }
        public bool IsLibrary { get; set; }

        public Book(string nameBook, string typeBook, int ageBook, bool isLibrary)
        {
            NameBook = nameBook;
            TypeBook = typeBook;
            AgeBook = ageBook;
            IsLibrary = isLibrary;
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book.IsLibrary)
                books.Add(book);
        }

        public List<Book> GetBooks() => books;
    }

    public class UnitTest1
    {
        [Fact]
        public void AddBook_WhenBookIsInLibrary_BookIsAdded()
        {
            Library library = new Library();
            Book book = new Book("Harry Potter", "Fantasy", 5, true);

            library.AddBook(book);

            Assert.Contains(book, library.GetBooks());
        }

        [Fact]
        public void AddBook_WhenBookIsNotInLibrary_BookIsNotAdded()
        {
            Library library = new Library();
            Book book = new Book("Test Book", "Test Type", 1, false);

            library.AddBook(book);

            Assert.DoesNotContain(book, library.GetBooks());
        }
    }
}
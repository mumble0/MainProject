using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Library library = new Library();

            Book book1 = new Book("Кобзар", "Поезія", 180, true);
            Book book2 = new Book("1984", "Роман", 75, true);
            Book book3 = new Book("Математика", "Навчальна", 10, false);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("Книги в бібліотеці:");
            library.ShowBooks();
        }
    }
}
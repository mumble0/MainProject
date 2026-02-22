using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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

        public override string ToString()
        {
            return $"{NameBook}, {TypeBook}, {AgeBook} років, " +
                   $"{(IsLibrary ? "є в бібліотеці" : "не в бібліотеці")}";
        }
    }
}

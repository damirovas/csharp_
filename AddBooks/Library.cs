using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBooks
{
    internal class Library
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Books[] books = { };
        public Library(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public void AddBooks(Books book)
        {
            Array.Resize(ref books ,books.Length+1);
            books[books.Length-1] = book;
        }
        public void GetBook()
        {
            foreach(Books book in books)
            {
                Console.WriteLine(book);
            }
        }

    }
}

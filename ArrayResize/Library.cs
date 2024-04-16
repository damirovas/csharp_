using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResize
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }

        public Book[] books = { };

        public Library(int id,string name, int limit)
        {
            Id = id;
            Name = name;
            Limit = limit;

        }

        public void AddBook (Book book)
        {
            if (books.Length < Limit)
            {
                Array.Resize (ref books, books.Length+1);
                books[books.Length-1] = book;
            }
            else
            {
                Console.WriteLine("bu grup uzre yerler dolub");
            }
        }

        public void GetBook()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void DeleteBook(int id)
        {
            Book[] newBooks = {};
            Book[] removedBooks = null; 

            foreach (Book book in books)
            {
                if (book.Id != id)
                {
                    Array.Resize(ref newBooks,newBooks.Length+1);
                    newBooks[newBooks.Length - 1] = book;
                }
                else
                {
                    removedBooks= books;
                    Console.WriteLine(removedBooks + " silindi");
                }
            }
            books = newBooks;
        }
        public void EditBooks(int id,Book book)
        {
            foreach(Book kitab in books)
            {
                if (kitab.Id == id)
                {
                    kitab.Id = book.Id;
                    kitab.Name= book.Name;
                    kitab.Author= book.Author;
                    kitab.Page= book.Page;
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }
    }
}

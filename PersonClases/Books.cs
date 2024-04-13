using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClases
{
    internal class Books
    {
        public int Id { get; set; }
        public int Page {  get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public Books(int id,int page,string name,string author)
        {
            Id = id;
            Page = page;
            Name = name;
            Author = author;
        }
        public string GetFullBook()
        {
            return $"Id:{Id},Page:{Page},Name:{Name},Author:{Author}";
        }
    }
}

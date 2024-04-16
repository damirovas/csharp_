﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResize
{
    internal class Book
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }

        public Book(int id,string name,string author,int page)
        {
            Id = id;
            Name = name;
            Author = author;
            Page = page;
        }
        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Author:{Author},Page:{Page}";
        }
    }
}

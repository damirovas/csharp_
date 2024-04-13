﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBooks
{
    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Author { get; set; }
        public int Page {  get; set; }

        public Books(int id,string name,string author,int page)
        {
            Id= id;
            Name= name;
            Author= author;
            Page= page;
        }

        public override string ToString()
        {
            return $"{Name} {Author} {Page}";
        }
    }
}

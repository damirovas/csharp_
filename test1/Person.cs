using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }


        public Person(int id,string name,string lastname )
        {
            ID = id;
            Name = name;
            LastName = lastname;
        }

        public string GetFullPerson()
        {
            return $"Id:{ID},Name:{Name},lastname:{LastName}";
        }
    }
}

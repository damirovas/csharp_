using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethodtekrar
{
    internal class Person
    {
        public int ID;
        public string Name;
        public string LastName;


        public Person(int id,string name,string firstname)
        {
            ID= id;
            Name= name;
            LastName= firstname;
        }

        public string GetFullName()
        {
            return $" Id:{ID}Name:{Name} ,LastName:{LastName}";
        }
    }
}

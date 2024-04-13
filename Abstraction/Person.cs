using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(string name,string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        
        public abstract void Work();

        public void GetFullName()
        {
            Console.WriteLine($"Name:{Name} LastName:{LastName}");
        }
    }
}

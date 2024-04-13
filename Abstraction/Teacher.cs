using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Teacher : Person
    {
        public Teacher(string name, string lastname) : base(name, lastname)
        {
            Name= name;
            LastName= lastname;
        }

        public override void Work()
        {
            Console.WriteLine($" {GetFullName} TEacher but she wants to be a developer :) ");
        }
    }
}

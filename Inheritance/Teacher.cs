using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher : Person
    {
        public int Experiences { get; set; }
        public Teacher(int id, string name, string lastname, int experiences) : base(id, name, lastname)
        {
            Experiences = experiences;
        }

        public override void GetFullName()
        {
            Console.WriteLine($"this peroson works for{Experiences}");
        }
    }
}

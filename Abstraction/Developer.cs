using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Developer : Person
    {
        public Developer(string name, string lastname) : base(name, lastname)
        {
        }

        public override void Work()
        {
            Console.WriteLine($"{GetFullName}she is developer");
        }
    }
}

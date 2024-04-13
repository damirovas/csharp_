using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphyism
{
    internal class Vehicle
    {
        public int Speed { get; set; }

        public Vehicle( int speed)
        {
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine("Vehicle is moving");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : Person
    {
        public double Point {  get; set; }
        public Student(int id, string name, string lastname, double point) : base(id, name, lastname)
        {
            Point = point;
        }
        public override void GetFullName()
        {
            Console.WriteLine($"this student grauated with {Point}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

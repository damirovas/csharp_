using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Student
    {
        //public static  int _id { get; set; }
        //public int Id { get; set; }
        //public Student()
        //{
        //    _id++;
        //    Id = _id;

        //}
        //auto incremention
        public static int _id;
        public int Id { get; set; }
        public Student() 
        {
            _id++;
            Id = _id;
        }


    }
}

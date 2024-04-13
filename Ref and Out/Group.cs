using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_and_Out
{
    internal class Group
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Limit { get; set; }
        public Student[] students = {};
        public Group(int id,string name,int limit)
        {
            Id=id;
            Name=name;
            Limit = limit;
        }
        public void AddStudent(Student student)
        {
           Array.Resize(ref students,students.Length+1);
            students[students.Length - 1] = student;
        }
        public void RemoveStudent(int id) 
        { 

        }
        public void GetStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }   
}

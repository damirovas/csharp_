namespace Ref_and_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group(1,"C#191",5);
            group.AddStudent(new Student(1, "SEMA", "DAMIROVA"));
            group.AddStudent(new Student(2, "huseyn", "huseynov"));
            group.GetStudents();
        }
    }
}

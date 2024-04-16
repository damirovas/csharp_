namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const double PI =3.14;
            //Console.WriteLine(PI*3);
            //Student student = new Student(9);
            //student._id = 4;error
            //Console.WriteLine(student._id);
            Student student1 = new Student();
            Student student2 = new Student();
            Console.WriteLine(student1.Id);
            Console.WriteLine(student2.Id);

        }

    }
}

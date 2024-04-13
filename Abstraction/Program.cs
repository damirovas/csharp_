namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name= Console.ReadLine();
            Console.WriteLine("enter your lastname");
            string lastname= Console.ReadLine();

            Teacher teacher=new Teacher(name,lastname);
            teacher.Work();
        }
    }
}

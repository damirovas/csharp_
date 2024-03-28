namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rt1= new Rectangle(3,7);

            Console.WriteLine(rt1.GetArea());
            Console.WriteLine(rt1.GetPerimeter());

        }
    }
}

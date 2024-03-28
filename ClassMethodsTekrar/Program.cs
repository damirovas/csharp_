namespace ClassMethodsTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle(5,9,7);
            //tr1.First = 5;
            //tr1.Second=6;
            //tr1.Third = 7;
            //tr1.SetSides(6, 9, 10);
            //Console.WriteLine(tr1.GetPerimeter());
            Console.WriteLine(tr1.GetPerimeter());
        }
    }
}

namespace AddBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library(1, "aaa");
            lib.AddBooks(new Books(1, "AAA", "SSSS", 4455));
            lib.GetBook();
        }
    }
}

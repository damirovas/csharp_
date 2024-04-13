namespace PersonClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books[] books = new Books[3];

            string result = EnterChoosens();

            while (result != "0")
            {
                switch(result)
                {
                    case "1":
                        (int id, int page, string name, string author) bookdetails = BookDetails();
                        Books book = new Books(bookdetails.id, bookdetails.page, bookdetails.name, bookdetails.author);
                        for(int i = 0; i < books.Length; i++)
                        {
                            if (books[i] !=null) continue;
                            else
                            {
                                books[i] = book;
                                break;
                            }
                        }
                        result = EnterChoosens();
                        break;
                        case "2":
                        foreach(Books bk in books)
                        {
                            if (bk is null) continue;
                            else
                            {
                                Console.WriteLine(bk.GetFullBook());

                            }
                        }
                        result= EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        result = EnterChoosens();
                        break;


                }
            }
            
        }
        static string EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun : 0 secin");
            Console.WriteLine("Kitab elave etmek ucun:1 secin");
            Console.WriteLine("Kitablari gormek ucun:2 secin");
            string result= Console.ReadLine();
            return result;
        }

        static (int,int,string,string) BookDetails()
        {
            Console.WriteLine("Kitab ID daxil edin :");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Kitab sehife sayi daxil edin :");
            int page=int.Parse(Console.ReadLine());
            Console.WriteLine("Kitab adini geyd edin :");
            string name= Console.ReadLine();
            Console.WriteLine("Author geyd edin :");
            string author= Console.ReadLine();

            return (id, page, name, author);
        }
    }
}

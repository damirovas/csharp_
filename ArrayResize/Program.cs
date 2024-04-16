using System.Text;
using System.Text.RegularExpressions;

namespace ArrayResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int choose = EnterChosens();
            Library library = null;
            while(choose != 0)
            {
                switch (choose)
                {
                    case 1:
                        library = LibraryDetails();
                        choose = EnterChosens();
                        break;
                    case 2:

                        Book bk = BookDetails();
                        library?.AddBook(bk);
                        choose = EnterChosens();
                        break;
                    case 3:
                        Console.WriteLine("silinecek kitabin Id sini daxil edin");
                        int id= int.Parse(Console.ReadLine());
                        library?.DeleteBook(id);
                        choose = EnterChosens();
                        break;
                    case 4:
                        library?.GetBook();
                        choose=EnterChosens();
                        break;
                        case 5:
                        Console.WriteLine("deyisecek kitabin Id sini daxil edin");
                        int EditId = int.Parse(Console.ReadLine());
                        Book EditedBook=BookDetails();
                        library?.EditBooks(EditId,EditedBook);
                        choose= EnterChosens();
                        break;
                    default:
                        Console.WriteLine("wrong chosen");
                        choose = EnterChosens();
                        break;
                }
            }

        }
        static int EnterChosens()
        {
            Console.WriteLine("cixis etmek ucun 0 secin");
            Console.WriteLine("Library elav etmek ucun 1 secin");
            Console.WriteLine("Book elav etmek ucun 2 secin");
            Console.WriteLine("book delete etmek ucun 3 secin");
            Console.WriteLine("book deyismek ucun 5 secin");
            Console.WriteLine("booklari gormek ucun 4 secin");
            int choose = int.Parse(Console.ReadLine());
            return choose;
        }
        static Library LibraryDetails()
        {
            Console.WriteLine("Id ni daxil edin");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine("enter name of the Group");
            string name= Console.ReadLine();
            Console.WriteLine("qrupun limitini daxil edin");
            int limit= int.Parse(Console.ReadLine());

            Library lib = new Library(id, name, limit);
            return lib;
        }
        static Book BookDetails()
        {
            Console.WriteLine("enter id");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine("enter book name");
            string name= Console.ReadLine();
            Console.WriteLine("enter author of the book");
            string author= Console.ReadLine();
            Console.WriteLine("enter page of yhe book");
            int page = int.Parse(Console.ReadLine());
            Book bk = new Book(id, name, author, page);
            return bk;
        }

    }
}

using System.ComponentModel;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 2, 4,6,3,5};

            //int result = 0;
            //foreach (int i in arr)
            //{
            //    result += i;
            //}
            //Console.WriteLine(result);

            //int num = Int32.MinValue;

            //foreach(int i in arr)
            //{
            //    if (i > num) num = i;
            //}
            //Console.WriteLine(num);

            //string str = "sema";
            //string result = "";
            //foreach (char ch in str)
            //{
            //    if (ch == 's') continue;
            //    result += ch;
            //}
            //Console.WriteLine(result);

            //Console.WriteLine("derinliyi secin");
            //int deepth = int.Parse(Console.ReadLine());
            //int a = 1;
            //int b= 1;

            //for(int i = 1; i < deepth; i++)
            //{
            //    int c = a + b;
            //    a = b;
            //    b = c;
            //    c = a + b;
            //    Console.WriteLine(c);

            //}

            Console.WriteLine("derinliyi secin :");
            int deepth = int.Parse(Console.ReadLine());

            int a = 1;
            int b=1;
            for(int i = 1; i <= deepth; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                c = a + b;

                Console.WriteLine(c);
            }


        }
    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Analytics
            //int num = 10;
            //int num2 = 15;
            ////+
            //Console.WriteLine(num+num2);
            ////-
            //Console.WriteLine(num-num2);
            ////*
            //Console.WriteLine(num*num2);
            //// /
            //Console.WriteLine(num / num2);
            //// %
            //Console.WriteLine(num%num2);

            //double d1 = 12.4;
            //double d2 = 2;
            //Console.WriteLine(d1 / d2);
            #endregion

            #region Assignment
            //double db =6.2;
            //  double db2 = 2;
            //  Console.WriteLine(db/db2);


            #endregion



            //Console.WriteLine("eded daxil edin");
            //int num = int.Parse(Console.ReadLine());

            //if(num%2==0 && num%3==0) {
            //    Console.WriteLine($"{num} 6 bolunur");

            //}else if(num%3==0)
            //{
            //    Console.WriteLine($"{num} 3 e bolunur");
            //}else if(num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} 2 e bolunur");
            //}else
            //{
            //    Console.WriteLine($"{num} sadedir ");
            //}


            //Console.WriteLine(" bir eded daxil edin");
            //int num = int.Parse(Console.ReadLine());

            //switch(num)
            //{
            //    case int when num % 2 == 0 && num % 3 == 0:
            //        Console.WriteLine("bu eded 6 ya bolunur");
            //        break;
            //    case int when num % 2 == 0 :
            //        Console.WriteLine("bu eded 2 ya bolunur");
            //        break;
            //    case int when  num % 3 == 0:
            //        Console.WriteLine("bu eded 3 ya bolunur");
            //        break;
            //    default:
            //        Console.WriteLine("eded ne 3e ne 2 ye bolunmur");
            //        break;
            //}

            Console.WriteLine("eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            string result = num % 2 == 0 && num % 3 == 0 ? "eded 6ya bolunur" :
                (num % 2 == 0 ? "eded 3 ebolunur" :
                (num %3==0 ? "eded 2 ye bolnue":
                "eded ne 2ye neded 3e bolunmur"
                ));
            Console.WriteLine(result);
        }
    }
}

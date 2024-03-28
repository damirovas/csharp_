using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;
            //while (num < 100)
            //{
            //    num += 5;
            //    Console.WriteLine(num);
            //}

            //int result = 0;

            //for(int i = 0;i<=10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        result += i;

            //    }

            //}
            //Console.WriteLine(result);

            //int result = 1;
            //for(int i = 1;i<=10;i++)
            //{
            //    if(i%2==1)
            //    {
            //        result *= i;
            //    }
            //}
            //Console.WriteLine(result);

            //int result = 0;

            //for (int i = 0;i<10; i++)
            //{
            //    if(i!=5 && i != 7)
            //    {
            //        result += i;
            //    }
            //}
            //Console.WriteLine(result);

            //int  num = int.Parse(Console.ReadLine());
            //int result = 0;
            //for(int i = 0;i<=num; i++)
            //{
            //    result += i;
            //    if (result > 40) break;

            //}
            //Console.WriteLine(result);

            //Console.WriteLine(" edeed daxil edin");
            //int num = int.Parse(Console.ReadLine());


            //int result = 0;
            //while(num>0)
            //{
            //    result += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(result);
            //int[,] twodim = new int[3, 3] { { 3, 4, 5 }, { 7, 8, 9 }, { 4, 4, 5 } };
            //int result = 0;
            //for(int i = 0; i < twodim.GetLength(0); i++)
            //{
            //    for(int j = 0; j < twodim.GetLength(1); j++)
            //    {
            //        Console.Write(twodim[i, j] +" ");
            //        if (i == j) result += twodim[i, j];
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(result);

            //int[,] twodim = new int[3, 3] { { 2, 3, 4 }, { 5, 8, 11 }, { 2, 5,7} };
            //int result = 0;
            //for(int i = 0; i < twodim.GetLength(0); i++)
            //{
            //    for(int j = 0; j < twodim.GetLength(1); j++)
            //    {
            //        if (i + j == twodim.GetLength(0)-1) ; result += twodim[i, j];

            //    }

            //}
            //Console.WriteLine(result);  

            //Console.WriteLine("eddi daxil edin:");
            //string str= Console.ReadLine();
            //string reverse = "";
            //for(int i= str.Length-1;i>=0;i--)
            //{
            //    reverse += str[i];
            //}
            //Console.WriteLine(reverse);

            //Console.WriteLine("eni daxil edin:");
            //int width = int.Parse(Console.ReadLine());
            //Console.WriteLine("uzunzlugu daxil edin :");
            //int heigth = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= width; i++)
            //{
            //    for (int j = 1; j <= heigth; j++)
            //    {
            //        if (i == 1 || j == 1 || i == width || j == heigth) Console.Write("* ");
            //        else Console.Write("  ");

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("number yazin :");
            //int num =int.Parse(Console.ReadLine());

            //for(int i = 1; i <= num; i++)
            //{
            //    for(int j = 1; j <= num; j++)
            //    {
            //        if (i == 1 || j == 1 || i == num || j == num)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("eni daxil edin :");
            //int width = int.Parse(Console.ReadLine());
            //Console.WriteLine("uzunlugu daxil edin :");
            //int heigth = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= width; i++)
            //{
            //    for(int j = 1; j <= heigth; j++)
            //    {
            //        if(i==1||j==1|| i == width || j == heigth)
            //        {
            //            Console.Write("* ");

            //        }
            //        else
            //        {
            //            Console.Write("  ");

            //        }
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("stringi daxil edin:");
            //string str= Console.ReadLine();
            //char ch = ' ';
            //int max = int.MinValue;

            //for(int i = 0;i<str.Length;i++)
            //{
            //    int count = 0;
            //    for(int j = 0;j<str.Length;j++)
            //    {
            //        if (str[j] == str[i])
            //        {
            //            count++;
            //        }
            //        if (count > max)
            //        {
            //            ch = str[i];
            //            count = max;
            //        }
            //    }
            //}
            //Console.WriteLine(ch);


            //Console.WriteLine("stringi daxil edin:");
            //string str = Console.ReadLine();
            //char ch = ' ';
            //int max = int.MinValue;

            //for (int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j]) { count++; }
            //        if (count > max)
            //        {
            //            ch= str[i];
            //            max=count;

            //        }
            //    }
            //}
            //Console.WriteLine(ch);

            //Console.WriteLine("stringi yazin:");
            //string str= Console.ReadLine();
            //string newstr = " ";

            //for(int i = 0;i<str.Length;i++)
            //{
            //    for(int j = 0;j<str.Length;j++)
            //    {
            //        if (str[i] == str[2] || str[j] == str[4]) {

            //        }
            //    }
            //}

            //Console.WriteLine("ededi daxil edin");
            //int num =int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 1; j <= num; j++)
            //    {
            //        if (i >= j) Console.Write("* ");
            //        else Console.Write("  ");
            //    }
            //    Console.WriteLine("");
            //}
        }
    } 
  }
    


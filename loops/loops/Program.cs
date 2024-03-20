namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While
            //int num = 5;
            //while (num < 100)
            //{
            //    num += 5;
            //    Console.WriteLine(num);
            //}
            #endregion

            #region for
            //int result = 0;
            //for(int i = 0; i <=10;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        result += i;
            //    }


            //}
            //Console.WriteLine(result);


            int result = 1;
            for(int i = 1; i < 10; i++)
            {
                if(i%2==1)
                {
                    result *= i;
                }
            }
            Console.WriteLine(result);
            #endregion
            
        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 5, 6 };
            int[] arr2 = { 4, 7, 8 };


            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (arr1[i] != arr2[j]) ;
            //        Console.WriteLine(sim.Append());
            //    } 
            //}

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            // Array1'de olmayan öğeleri bulalım ve yazdıralım
            Console.WriteLine("Array1'de fakat Array2'de olmayanlar:");
            FindMissingItems(array1, array2);

            // Array2'de olmayan öğeleri bulalım ve yazdıralım
            Console.WriteLine("Array2'de fakat Array1'de olmayanlar:");
            FindMissingItems(array2, array1);
        }

        static void FindMissingItems(int[] array1, int[] array2)
        {
            foreach (var item1 in array1)
            {
                bool notFound = true;
                for (int i = 0; i < array2.Length; i++)
                {
                    if (item1 == array2[i])
                    {
                        notFound = false;
                        break;
                    }
                }
                if (notFound)
                {
                    Console.WriteLine(item1);
                }
            }

        }
        
    }
}
    


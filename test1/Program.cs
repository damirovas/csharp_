using System;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            string result = EnterChoosens();
            while(result!="0")
            {
                switch(result)
                {
                    case "1":
                        (int id, string name, string lastname) persondetails = Persondetails();
                        Person person= new Person(persondetails.id,persondetails.name,persondetails.lastname);
                        for (int i = 0; i < persons.Length; i++)
                        {
                            if (persons[i] != null) continue;
                            else
                            {
                                persons[i] = person;
                                break;

                            }
                        }
                        result= EnterChoosens();
                        break;
                        case "2":

                        foreach(Person per in persons)
                        {
                            if (per ==null) continue;
                            else
                            {
                                Console.WriteLine(per.GetFullPerson());
                            }
                        }
                        result= EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("yanlis secim");
                        result= EnterChoosens();
                        break;
                }
            }

        }
        static string EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun : 0 secin");
            Console.WriteLine("Person elave etmek ucun :1 secin");
            Console.WriteLine("Elave olunmus personlari gormek ucun :2 secin");
            string result= Console.ReadLine();
            return result;
        }

        //value touple using
        static (int,string,string) Persondetails()
        {
            Console.WriteLine("Id ni daxil edin");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine("name daxil edin");
            string name= Console.ReadLine();
            Console.WriteLine("Lastname daxil edin");
            string lasstname =Console.ReadLine();
            return (id,name,lasstname);
        }
       
    }
    
}

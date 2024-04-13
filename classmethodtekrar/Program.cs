namespace classmethodtekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[4];

            string result = EnterChoosens();

            while (result != "0")
            {
                switch (result)
                {
                    case "1":
                        (int id, string name, string lastname) persondeatils = PersonDetails();
                        Person person = new Person(persondeatils.id, persondeatils.name, persondeatils.lastname);

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
                            if (per == null) continue;
                            else Console.WriteLine(per.GetFullName());
                            break;
                            
                        }
                        result= EnterChoosens();
                        break;

                    default:
                        Console.WriteLine("yanlis secim");
                        result= EnterChoosens();
                        break;

                     }

                }

            static string EnterChoosens()
            {
                Console.WriteLine("Cixis etmek ucun: 0 secin");
                Console.WriteLine("Person elave etmak ucun : 1 secin");
                Console.WriteLine("Personlari goremk ucun : 2s secin");
                string result = Console.ReadLine();
                return result;
            }

            static (int, string, string) PersonDetails()
            {
                Console.WriteLine("enter Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter lastname");
                string lastname = Console.ReadLine();
                return (id, name, lastname);

            }
        }
    }
}
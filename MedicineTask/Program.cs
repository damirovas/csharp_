namespace MedicineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vitamins vit1 = new Vitamins("C vitamini", 90, "c");
            vit1.UsedFor();
            vit1.GetFullMedicine();
            Vitamins vit2 = new Vitamins("D vitamini", 70, "D");
            PainKiller painkiller = new PainKiller("Parasetamol", 80, 20.7);
            painkiller.UsedFor();
            painkiller.GetFullMedicine();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineTask
{
    internal class Vitamins : Medicine
    {
        public string Composition {  get; set; }
        public Vitamins(string name, int price,string composition) : base(name, price)
        {
            Composition = composition;
        }

        public override void GetFullMedicine()
        {
            Console.WriteLine($"{Name},{Price},{Composition}");
        }
        public override void UsedFor()
        {
            Console.WriteLine($"{Name} is used for keep healty");
        }
        public override string ToString()
        {
            return "Vitamin";
        }
    }
}

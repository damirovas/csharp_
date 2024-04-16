using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineTask
{
    internal class PainKiller : Medicine
    {
        public double Mg {  get; set; }
        public PainKiller(string name, int price,double mg) : base(name, price)
        {
            Mg= mg;
        }

        public override void UsedFor()
        {
            Console.WriteLine($"{Name} used for eliminate pain");
        }
        public override void GetFullMedicine()
        {
            Console.WriteLine($"Name:{Name},Price:{Price},Mg:{Mg}");
        }
        public override 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineTask
{
    internal abstract class Medicine
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Medicine(string name,int price)
        {
            Name = name;
            Price = price;
        }

        public abstract void UsedFor();

        public virtual void GetFullMedicine()
        {
            Console.WriteLine($"Name:{Name} ,Price:{Price}");
        }

    }
}

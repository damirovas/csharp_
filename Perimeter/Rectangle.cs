using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter
{
    internal class Rectangle
    {
        public int First;
        public int birinci {
            get
            { 
                return First; 
            }
            set
            {
                if (value < 0) birinci = 0;
                else birinci=value;
            }
        }

        public int ikinci;

        public Rectangle(int birinci, int ikinci)
        {
            this.birinci = birinci;
            this.ikinci = ikinci;
        }

        public int GetPerimeter()
        {
            return 2*(birinci+ikinci);
        }
        public int GetArea()
        {
            return birinci * ikinci;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsTekrar
{
    internal class Triangle
    {
        private int birinci;
        public int First
        {
            get
            {
                return birinci;
            }
            set
            {
                if (value < 0) birinci = 0;
                else birinci = value;
            }
        }

        public int Second { get; set; }
        public int Third { get; set; }

        //public void SetSides(int first, int second,int third)
        //{
        //    this.First = first;
        //    this.Second = second;
        //    this.Third = third;
        //}
        public Triangle(int first ,int second,int third)
        {
            First=first; Second=second; Third=third;
        }
        public int GetPerimeter()
        {
            return First + Second + Third;
        }
    }
}

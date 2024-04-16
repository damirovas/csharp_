using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal static class DeleteChar
    {
        public static string Deletechar(this string str,char ch)
        {
            string newStr = "";
            foreach(char chr in str)
            {
                if (chr != ch)
                {
                    newStr += chr;
                }
            }
            return newStr;
        }
    }
}

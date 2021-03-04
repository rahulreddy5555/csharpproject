using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    public static class StringExtension
    {
        public static int getcount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] strarray = inputstring.Split(' ');
                return strarray.Count();
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    public static class ExtensionsDemo
    {
        public static bool IsGreaterThan(this int i, int value)  //extension method
        {
            return i > value;
        }
    }
}

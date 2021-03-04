using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class SqrtPreCalculated
    {
        public const int MAX_VALUE = 10000;
        public static int[] sqrtValues;
         static SqrtPreCalculated()
        {
            sqrtValues = new int[MAX_VALUE + 1];
            for(int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }
        public static int getSqrt(int val)
        {
            return sqrtValues[val];
        }
        static void Main()
        {
            Console.WriteLine("sqrt  is: {0} ",getSqrt(16));
            Console.ReadKey();
        }
    }
}

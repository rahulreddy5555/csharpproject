using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class TernaryDemo
    {
        /* Ternary operator are a substitute for if...else statement.

     Syntax : Condition ? Expression1 : Expression2;
    */
        public static void Main()
        {
            int num = 2;
            bool isEven;
            isEven = (num % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

            int n1 = 20, n2 = 30;
            String b;
            b= n1 > n2 ? "n1 is greater than n2": n1<n2?"n2 is greater than n1":"n1 is equal to n2";
            Console.WriteLine(b);
        

            Console.ReadKey();
        }
    }
}

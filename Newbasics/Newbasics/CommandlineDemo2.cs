using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class CommandlineDemo2
    {
        public static void Main(String[] args)
        {
            int a = Int32.Parse(args[0]);
            int b= Int32.Parse(args[1]);
            int c= Int32.Parse(args[2]);
            int sum = a + b + c;
            float avg = sum / 3;
            Console.WriteLine("sum is: " + sum);
            Console.WriteLine("avg is : {0:0} ", avg);
            Console.WriteLine("avg is : {0:0.00} " , avg);
            Console.WriteLine("avg is : {0:0.###} " , avg);
            Console.WriteLine("avg is : {0:C}", avg);
            Console.WriteLine(String.Format(new CultureInfo("en-US"),"{0:C}",avg));



            Console.ReadKey();
        }
    }
}

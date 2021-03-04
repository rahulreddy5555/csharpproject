using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    public partial class Customer
    {
        int amount;
        public void depostamt(int d_amt)
        {
            amount += d_amt;
            Console.WriteLine("deposited" + d_amt);
            Console.WriteLine("balane" + amount);
        }
      
    }
}

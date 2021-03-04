using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    public partial class Customer
    {

            public int Amount { get { return amount; } set { amount = value;} }
        public void withdrawamt(int w_amt)
        {
            amount -= w_amt;
            Console.WriteLine("deposited" + w_amt);
            Console.WriteLine("balane" + amount);
        }
    }
}

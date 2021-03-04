using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myclasslibrary;

namespace OopsDemo
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            ChangeCharacter c = new ChangeCharacter();
           Console.WriteLine(c.uppercase("hello in accounttest-uppercase"));
            Console.WriteLine(c.uppercase("******************************"));
            Console.WriteLine(c.lowercase("hello in accounttest-lowercase"));
            Console.WriteLine(c.uppercase("******************************"));


            //create an instance of Account
            Accounts objAccount = new Accounts(1000);
            Console.WriteLine("After creating account :");
            objAccount.ShowBalance();

            objAccount.deposit(5000);
            Console.WriteLine("After depositing amount :");
            objAccount.ShowBalance();

            objAccount.withdraw(6000);
            Console.WriteLine("After withdrawing :");
            objAccount.ShowBalance();
            Console.ReadKey();
        }
    }
}

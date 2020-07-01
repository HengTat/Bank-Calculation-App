using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphrism
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount John = new BankAccount("5518", "John", 6000);
            BankAccount Tammy = new BankAccount("5518", "Tammy", 2000);
            John.Withdraw(500);
            John.Deposit(3000);
            Tammy.Withdraw(300);
            Tammy.Deposit(2000);
            John.TransferTo(200, Tammy);
            John.CalculateInterest();
            John.CreditInterest();
            Console.WriteLine(John.Balance);
            Console.WriteLine(Tammy.Balance);
            Console.Read();
        }
    }
}


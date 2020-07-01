using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphrism
{
    public class SavingsAccount : BankAccount
    {
        private static double interestRate = 1;
        public SavingsAccount(string acctNumber, string acctHolderId, double abalance)
            : base(acctNumber, acctHolderId, abalance)
        {

        }

        public override double CalculateInterest()
        {
            double AnnualInterest = (Balance * interestRate) / 100;
            return AnnualInterest;
        }

        public override double CreditInterest()
        {
            Deposit(CalculateInterest());
            return this.Balance;
        }
        public override double Withdraw(double amount)
        {
            if (Balance > amount)
            {
                return Withdraw(amount);
            }
            else
                Console.WriteLine("Invalid Entry, Account has insufficient funds");
            return Balance;

        }

    }
}
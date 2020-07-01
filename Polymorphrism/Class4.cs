using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphrism
{
    public class OverDraftAccount : BankAccount
    {
        private static double interestRate = 0.25;
        private static double higherinterestRate = 0.6;
        public OverDraftAccount(string acctNumber, string acctHolderId, double abalance)
            : base(acctNumber, acctHolderId, abalance)
        {

        }

        public override double CalculateInterest()
        {
            if (Balance > 0)
            {
                double AnnualInterest = (Balance * interestRate) / 100;
                return AnnualInterest;
            }
            else
            {
                double AnnualInterest = (Balance * higherinterestRate) / 100;
                return AnnualInterest;
            }

        }

        public override double Withdraw(double amt)
        {

            Balance = Balance - amt;
            return Balance;

        }

    }

}

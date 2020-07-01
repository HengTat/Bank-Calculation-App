using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphrism
{
    public class BankAccount  
    {
        private string acctNumber;
        private string acctHolderId;
        private double balance;
        private double interestRate = 0.5;

        public BankAccount(string acctNumber, string acctHolderId, double abalance)
        {
            AcctNumber = acctNumber;
            AcctHolderId = acctHolderId;
            Balance = abalance;

        }

        public string AcctNumber
        {
            get
            {
                return this.acctNumber;
            }
            set
            {
                if (value != null)
                {
                    this.acctNumber = value;
                }
                else
                {
                    this.acctNumber = "Error";
                }
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value > 0)
                {
                    this.balance = value;
                }
                else
                {
                    this.balance = 0;
                }
            }
        }

        public string AcctHolderId
        {
            get
            {
                return this.acctHolderId;
            }
            set
            {
                if (value != null)
                {
                    this.acctHolderId = value;
                }
                else
                {
                    this.acctHolderId = "Invalid";
                }
            }
        }

        public double InterestRate
        {
            get
            {
                return InterestRate;
            }

            set
            {
                if (value < 0)
                {
                    this.InterestRate = value;
                }
                else
                {
                    this.InterestRate = 0;
                }

            }
        }


        public virtual double Withdraw(double amt)
        {
            this.balance = this.balance - amt;
            return this.balance;
        }
        public virtual double Deposit(double amt)
        {
            this.balance = balance + amt;
            return this.balance;
        }
        public virtual double TransferTo(double amt, BankAccount bankaccount)
        {
            Withdraw(amt);
            bankaccount.Deposit(amt);
            return this.balance;
        }

        public virtual double CalculateInterest()
        {
            double AnnualInterest = (balance * interestRate) / 100;
            return AnnualInterest;
        }

        public virtual double CreditInterest()
        {
            Deposit(CalculateInterest());
            return this.balance;
        }
    }
}


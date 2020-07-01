using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphrism

{
    public class BankBrunch
    {
        private string BranchName { get; set; }
        private string BranchManager { get; set; }
        private List<BankAccount> ListofBankAccounts;
        public BankBrunch(string branchName, string branchManager)
        {
            BranchName = branchName;
            BranchManager = branchManager;
        }

        public void AddAccount(BankAccount AcctNo)
        {
            ListofBankAccounts.Add(AcctNo);
        }

        public void PrintCustomers()
        {
            for (int i = 0; i < ListofBankAccounts.Count; i++)
                Console.WriteLine(ListofBankAccounts[i]);
        }



        public void CreditInterest()
        {
            for (int i = 0; i < ListofBankAccounts.Count; i++)
            {
                BankAccount a = ListofBankAccounts[i];
                a.CreditInterest();
            }

        }

        public double TotalDeposit()
        {
            double TotalDep = 0;
            for (int i = 0; i < ListofBankAccounts.Count; i++)
            {
                BankAccount a = ListofBankAccounts[i];
                double x = a.Balance;
                TotalDep += x;
            }

            return TotalDep;
        }



        public double TotalInterestPaid()
        {
            double Total = 0;
            for (int i = 0; i < ListofBankAccounts.Count; i++)
            {
                BankAccount a = ListofBankAccounts[1];
                double x = a.CalculateInterest();
                Total += x;
            }
            return Total;
        }

        public double TotalInterestEarned()
        {
            
                double Total = 0;
                for (int i = 0; i < ListofBankAccounts.Count; i++)
                {
                    BankAccount a = ListofBankAccounts[1];
                    double x = a.CalculateInterest();
                    Total += x;
                }
                return Total;
            
           
        }

        

    }
}

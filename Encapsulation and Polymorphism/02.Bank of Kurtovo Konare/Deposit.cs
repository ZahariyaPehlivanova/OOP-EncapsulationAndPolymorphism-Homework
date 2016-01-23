using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public override decimal CalculateInterest(decimal money, int months)
        {
            if (money < 1000)
            {
                return 0;
            }
            return money * (1 + this.InterestRate * months);
        }

        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}

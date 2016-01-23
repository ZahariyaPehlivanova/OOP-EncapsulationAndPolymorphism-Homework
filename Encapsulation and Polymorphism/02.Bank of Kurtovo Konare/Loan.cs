using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
             : base(customer, balance, interestRate)
        {
        }
        public override decimal CalculateInterest(decimal money, int months)
        {
            if (months < 3 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 2 && this.Customer == Customer.Company)
            {
                return 0;
            }
            return money * (1 + this.InterestRate * months);
        }
    }
}

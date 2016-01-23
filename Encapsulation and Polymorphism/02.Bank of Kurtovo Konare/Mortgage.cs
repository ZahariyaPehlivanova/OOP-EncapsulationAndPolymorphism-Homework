using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class Mortage : Account
    {
        public Mortage(Customer customer, decimal balance, decimal interestRate)
             : base(customer, balance, interestRate)
        {
        }
        public override decimal CalculateInterest(decimal money, int months)
        {
            if (months < 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 12 && this.Customer == Customer.Company)
            {
                return (money * (1 + this.InterestRate * months)) / 2;
            }
            return money * (1 + this.InterestRate * months);
        }
    }
}

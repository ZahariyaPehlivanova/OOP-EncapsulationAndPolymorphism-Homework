using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    using Interfaces;
    abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Customer
        {
            get { return this.customer; }
            set {this.customer = value; }
        }
        public decimal Balance
        {
            get {return this.balance;}
            set {this.balance = value;}
        }
        public decimal InterestRate
        {
            get{return this.interestRate;}
            set{this.interestRate = value;}
        }
        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(decimal money, int months);

    }
}

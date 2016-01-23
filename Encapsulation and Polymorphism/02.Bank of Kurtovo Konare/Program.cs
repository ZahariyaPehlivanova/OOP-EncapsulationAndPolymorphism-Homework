using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Individual customer:");
            Deposit depo = new Deposit(Customer.Individual, 4321, 3.4m);
            Console.WriteLine(depo.Balance);
            depo.DepositMoney(100m);
            Console.WriteLine(depo.Balance);
            depo.Withdraw(1000m);
            Console.WriteLine(depo.Balance);
            Console.WriteLine();
            Console.WriteLine("Company customer:");
            Deposit depo2 = new Deposit(Customer.Individual, 1234, 2.1m);
            Console.WriteLine(depo2.Balance);
            depo2.DepositMoney(200);
            Console.WriteLine(depo2.Balance);
            depo2.Withdraw(1000);
            Console.WriteLine(depo2.Balance);
            Console.WriteLine();
        }
    }
}

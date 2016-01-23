using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare.Interfaces
{
    interface IAccount
    {
        void DepositMoney(decimal money);

        decimal CalculateInterest(decimal money, int months);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConstructor
{
    public class SavingsAccount:BankAccount
    {
        public double InterestAmount { get; set; }
        public SavingsAccount(string accountNo, string customerName,double interestAmount):base(accountNo, customerName)
        {
            InterestAmount = interestAmount;
        }
    }
}

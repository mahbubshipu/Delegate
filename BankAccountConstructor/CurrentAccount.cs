using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConstructor
{
    public class CurrentAccount:BankAccount
    {   
        public CurrentAccount(string accountNo, string customerName, double servicechare):base(accountNo, customerName)
        {
            ServiceCharge = servicechare;

        }
        public double ServiceCharge { get; set; }
    }
}

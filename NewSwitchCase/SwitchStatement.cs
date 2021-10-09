using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSwitchCase
{
    public class Bank
    {
        public BankBrachStatus Status  { get; set; }
    }
    public enum BankBrachStatus 
    { 
        Open, Close,VIPCustomerOnly
    }

}

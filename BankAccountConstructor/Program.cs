using System;

namespace BankAccountConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            Console.WriteLine();
            SavingsAccount sa = new SavingsAccount("1254","Mahbub",15000);
            Console.WriteLine(sa.AccountNo+" "+sa.CustomerName+" "+sa.InterestAmount);
            CurrentAccount ca = new CurrentAccount("22556", "Jerin", 16000);

        }
    }
}

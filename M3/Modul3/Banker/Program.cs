using System;

namespace Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.AddAccount("1");
            Bank.Deposit("1", 1000);
            Bank.Withdraw("1", 100);
            Console.WriteLine(Bank.GetBankAccountByID("1"));
        }
    }
}

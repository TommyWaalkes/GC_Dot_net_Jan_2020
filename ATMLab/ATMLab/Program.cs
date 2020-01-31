using System;
using System.Collections.Generic;

namespace ATMLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM a = new ATM();
            List<Account> accounts = a.Accounts;
            foreach(Account acc in accounts)
            {
                Console.WriteLine(acc.Name);
            }
            a.CheckBalance();
            a.Logout();
            a.Login("Joey", "123456");
            a.CheckBalance();
            a.Deposit(2000);
            a.CheckBalance();

            a.Login("asdfghj", "12345678");
            a.Logout();
        }
    }
}

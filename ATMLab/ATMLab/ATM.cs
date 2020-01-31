using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLab
{
    class ATM
    {
        public Account CurrentAccount { get; set; }
        public List<Account> Accounts { get; set; }

        public ATM()
        {
            Accounts = new List<Account>();
            Accounts.Add(new Account("Joey", "123456", 150));
            Accounts.Add(new Account("Rich Boy Winston Toby", "money", 900000000));
            Accounts.Add(new Account("Jar Jar binks", "password", 1000));
        }

        public void Login(string name, string password)
        {
            for(int i = 0; i < Accounts.Count; i++)
            {
                Account a = Accounts[i];
                //Console.WriteLine(a.Password == password);
                if(a.Name == name)
                {
                    if(a.Password.ToLower() == password.ToLower())
                    {
                        CurrentAccount = a;
                        Console.WriteLine(name + " logged in");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("User name " + name + " was found but the password was incorrect");
                    }
                }
                else
                {
                    Console.WriteLine("name is not a match");
                }

                if(Accounts.Count - 1 >= i)
                {
                    Console.WriteLine("User name or password was incorrect, please try again");
                }
            }

           
        }

        public void Logout()
        {
            CurrentAccount = null;
        }

        public void CheckBalance()
        {
            if(CurrentAccount != null)
            {
                Console.WriteLine($"{CurrentAccount.Name} has ${CurrentAccount.Balance}");
            }
            else
            {
                Console.WriteLine("No user is logged in");
            }
        }

        public void Deposit(int amount)
        {
            if(CurrentAccount != null)
            {
                CurrentAccount.Balance += amount;
            }
            else
            {
                Console.WriteLine("No user logged in, no money is deposited");
            }
        }
    }
}

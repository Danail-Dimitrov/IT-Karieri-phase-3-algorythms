using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    static class Bank
    {
        private static int idGenerator;
        private static Dictionary<int, BankAccount> bankAccounts;

        public static void AddAccount ()
        {
            idGenerator++;
            var bankAccountToAdd = new BankAccount(idGenerator);
            bankAccounts.Add(idGenerator, bankAccountToAdd);
            Console.WriteLine($"The id of the Account is {idGenerator}");        
        }
        public static void Deposit (int id, double ammount)
        {
            bankAccounts[id].Deposit(ammount);
        }
        public static void Withdraw (int id, double ammount)
        {
            bankAccounts[id].Withdraw(ammount);
        }
        public static void Print (int id)
        {
            Console.WriteLine(bankAccounts[id]);
        }
        public static void PrintAll ()
        {
            foreach(var pair in bankAccounts)
            {
                Console.WriteLine(bankAccounts[pair.Key]);
            }
        }
    }
}

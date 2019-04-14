using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // id -> account
            var accounts = new Dictionary<int, BankAccount>();

            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(' ');

                switch (commandArgs[0])
                {
                    case "Create":
                        CreateAccount(commandArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(commandArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(commandArgs, accounts);
                        break;
                    case "Print":
                        PrintAccount(int.Parse(commandArgs[1]), accounts);
                        break;
                }
            }
        }

        private static void PrintAccount(int id, Dictionary<int, BankAccount> accounts)
        {
            if (checkAccountExists(id, accounts))
            {
                Console.WriteLine(accounts[id]);
            }
        }

        private static void CreateAccount(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(commandArgs[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists.");
            }
            else
            {
                BankAccount account = new BankAccount();
                account.ID = id;

                accounts.Add(id, account);
            }
        }

        private static void Deposit(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(commandArgs[1]);
            double amount = double.Parse(commandArgs[2]);

            if (checkAccountExists(id, accounts))
            {
                accounts[id].Deposit(amount);
            }
        }

        private static bool checkAccountExists(int id, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Account with id {id} does not exists!");
                return false;
            }
        }

        private static void Withdraw(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(commandArgs[1]);
            double amount = double.Parse(commandArgs[2]);

            if (checkAccountExists(id, accounts))
            {
                accounts[id].Withdraw(amount);
            }
        }
    }
}

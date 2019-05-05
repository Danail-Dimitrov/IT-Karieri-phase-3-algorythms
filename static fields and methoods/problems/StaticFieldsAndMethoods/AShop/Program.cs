using System;
using System.Linq;

namespace Bank
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
            while(commandArgs[0] != "end")
            {
                switch(commandArgs[0])
                {
                    case "AddAccount" :
                    Bank.AddAccount();
                    break;
                    case "Deposit":
                    Bank.Deposit(int.Parse(commandArgs[1]),double.Parse(commandArgs[2]));
                    break;
                    case "Withdraw":
                    Bank.Withdraw(int.Parse(commandArgs[1]), double.Parse(commandArgs[2]));
                    break;
                    case "Print":
                    Bank.Print(int.Parse(commandArgs[1]));
                    break;
                    case "PrintAll":
                    Bank.PrintAll();
                    break;
                }
            }
        }
    }
}

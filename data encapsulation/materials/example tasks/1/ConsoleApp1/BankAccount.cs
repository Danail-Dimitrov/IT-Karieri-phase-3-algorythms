using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Amount must be positive number!");
            }
            else
            {
                balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive number!");

            }else if(amount > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account {ID}, balance {balance:F2}";
        }
    }
}

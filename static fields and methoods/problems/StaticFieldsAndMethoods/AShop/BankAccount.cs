using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount (int id)
        {
            this.id = id;
        }

        public int Id
        {
            get => id;
        }
        public double Balance
        {
            get => balance;
        }

        public void Deposit (double ammount)
        {
            balance += ammount;
        }
        public void Withdraw (double ammount)
        {
            balance -= ammount;
        }

        public override string ToString ()
        {
            return $"BankAccaunt {id} has balance {balance}";
        }
    }
}

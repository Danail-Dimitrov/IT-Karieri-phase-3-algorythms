using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccounts
    {
        private string iban;
        private decimal ammount;

        public void Deposit (decimal ammount)
        {
            this.ammount += ammount;
        }

        public void Withdraw(decimal ammount)
        {
            this.ammount -= ammount;
        }
    }
}

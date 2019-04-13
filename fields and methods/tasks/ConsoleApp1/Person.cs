using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private int age;
        private string name;
        private List<BankAccounts> accounts = new List<BankAccounts>();

        public Person()
        {
        }

        public Person (int age, string name) : this(age, name, new List<BankAccounts>())
        {
        }

        public Person (int age, string name, List<BankAccounts> accounts)
        {
            this.age = age;
            this.name = name;
            this.accounts = accounts;
        }
        public List<BankAccounts> Accounts 
        {
            get { return accounts; }
            set { accounts = value; }        
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal GetBalance()
        {
            decimal ammount = 0m;
            foreach (var account in accounts)
            {
                ammount += account.Amount;
            }
            return ammount;
        }
    }
}

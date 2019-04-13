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
        private List<BankAccounts> accaounts;

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
            decimal ammount;
            return ammount;
        }
    }
}

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
            //the name of the App is bad it shuld be Person_Class
            Person person = new Person();
            person.Name = "Pesho";
            person.Age = 23;

            Person person2 = new Person();
            person2.Name = "Stamat";
            person2.Age = 33;

            Person person3 = new Person();
            person3.Name = "Gosho";
            person3.Age = 11;

            BankAccounts bankAccount = new BankAccounts();
            bankAccount.Deposit(2000.50m);
            bankAccount.Withdraw(1000.50m);

            BankAccounts bankAccount2 = new BankAccounts();
            bankAccount2.Deposit(30m);

            List<BankAccounts> accounts = new List<BankAccounts>();
            accounts.Add(bankAccount);
            accounts.Add(bankAccount2);

            person.Accounts = accounts;

            decimal a = person.GetBalance();

            Console.WriteLine();
        }
    }
}

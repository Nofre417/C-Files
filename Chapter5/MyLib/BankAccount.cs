using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyLib
{
    public class BankAccount
    {
        public string AccountName;
        public decimal Balance;
        public static decimal InterestRate;

        public readonly string BankName = "Imperial Bank";
        public readonly DateTime Instantiated;

        public BankAccount(string inputName, decimal balance)
        {
            AccountName = inputName;
            Balance = balance;
            Instantiated = DateTime.Now;
        }
    }
}

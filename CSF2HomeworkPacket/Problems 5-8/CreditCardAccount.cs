using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_5_8
{
    public class CreditCardAccount
    {
        private decimal _balance;

        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnualInterestRate { get; set; }
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 0;
                }
            }
        }

        public CreditCardAccount() { }

        public CreditCardAccount(int accountNumber, decimal anualInterestRate, decimal balance, Customer customerInfo, bool isPastDue)
        {
            AccountNumber = accountNumber;
            AnualInterestRate = anualInterestRate;
            Balance = balance;
            CustomerInfo = customerInfo;
            IsPastDue = isPastDue;
        }

        public override string ToString()
        {
            return string.Format("\nCustomer Info: {0}" +
                "\nBalance: {1:c}" +
                "\nAnnual Interest Rate: {2}%" +
                "\nAccount Number: {3}" +
                "\n{4}", CustomerInfo, Balance, AnualInterestRate, AccountNumber, IsPastDue ? "Account Past Due" : "Account not Past Due");
        }
    }
}

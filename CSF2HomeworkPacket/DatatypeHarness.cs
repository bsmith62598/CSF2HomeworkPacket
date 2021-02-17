using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems_1_4;
using Problems_5_8;

namespace CSF2HomeworkPacket
{
    class DatatypeHarness
    {
        static void Main(string[] args)
        {
            Student brandon = new Student("Brandon", "Smith", "123456", 3.6f);
            Console.WriteLine(brandon);

            Vehicle skyline = new Vehicle("Nissan", "Skyline", 1994, 3600);
            Console.WriteLine(skyline);

            Login me = new Login("Bsmith", "066598");
            Console.WriteLine(me);

            ContactInfo mySelf = new ContactInfo("123 W. Road", "Kansas City", "Kansas", "66065", "913-555-8965", "email@email.com");
            Console.WriteLine(mySelf);

            Customer c1 = new Customer();
            c1.FirstName = "Matt";
            c1.LastName = "Matt";
            c1.CustomerId = "123456";
            c1.ContactInformation = mySelf;

            Console.WriteLine("\nFirst Name: {0}" +
                "\nLast Name: {1}" +
                "\nCustomer ID: {2}" +
                "\n\nContact Info: {3}",c1.FirstName, c1.LastName, c1.CustomerId, c1.ContactInformation);

            Customer c2 = new Customer("Marvin", "Waltz", "777895", mySelf);
            Console.WriteLine(c2);

            CreditCardAccount card1 = new CreditCardAccount();
            card1.AccountNumber = 123456789;
            card1.AnualInterestRate = 5.3m;
            card1.Balance = 986.53m;
            card1.CustomerInfo = c1;
            card1.IsPastDue = false;

            Console.WriteLine("\n{0}" +
                "\nAccount Number: {1}" +
                "\nAnual Interest Rate: {2}" +
                "\nBalance: {3:c}" +
                "\n{4}", card1.CustomerInfo, card1.AccountNumber, card1.AnualInterestRate, card1.Balance, card1.IsPastDue ? "Account Past Due" : "Account not Past Due");

            CreditCardAccount card2 = new CreditCardAccount(1122334455, 4.5m, 300, c2, true);
            Console.WriteLine(card2);
        }
    }
}

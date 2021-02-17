using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems_1_4;

namespace Problems_5_8
{
    public class Customer
    {

        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        public Customer() { }

        public Customer(string firstName, string lastName, string customerId, ContactInfo contact)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = customerId;
            ContactInformation = contact;
        }

        public override string ToString()
        {
            return string.Format("\nFirst Name: {0}" +
                "\nLast Name: {1}" +
                "\nCustomer ID: {2}" +
                "\n\nContact Information: {3}", FirstName, LastName, CustomerId, ContactInformation);
        }
    }
}

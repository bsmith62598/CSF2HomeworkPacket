using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems_1_4;

namespace Customer
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
                "\nCustomer ID: {3}" +
                "\nContact Information: {4}", FirstName, LastName, CustomerId, ContactInformation);
        }
    }




}

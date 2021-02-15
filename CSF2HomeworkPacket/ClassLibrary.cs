using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2HomeworkPacket
{
    public class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Vehicle() { }

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("\nMake: {0}" +
                "\nModel: {1}" +
                "\nYear: {2}" +
                "\nWeight: {3}", Make, Model, Year, Weight);
        }
    }

    public class Student
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //Constructors/ctors
        public Student() { }

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("\nStudent first name: {0}" +
                "\nStudent last name: {1}" +
                "\nStudent ID: {2}" +
                "\nStudent GPA: {3}", FirstName, LastName, Id, Gpa);
        }
    }

    public class Login
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Login() { }

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public override string ToString()
        {
            return string.Format("\nUsername: {0}" +
                "\nPassword: {1}", UserName, Password);
        }
    }

    public class ContactInfo
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public ContactInfo() { }

        public ContactInfo(string streetaddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetaddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return string.Format("\nAddress: {0}" +
                "\nCity: {1}" +
                "\nState: {2}" +
                "\nZip: {3}" +
                "\nPhone: {4}" +
                "\nEmail: {5}", StreetAddress, City, State, Zip, Phone, Email);
        }   
    }
}

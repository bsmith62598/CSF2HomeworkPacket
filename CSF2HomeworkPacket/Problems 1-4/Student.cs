using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1_4
{
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
}

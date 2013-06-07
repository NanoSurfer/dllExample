using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Person
    {
        private string idNumber;

        public string IdNumber
        {
            get { return idNumber; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructor with zero values
        public Person()
        {
            idNumber = "";
            lastName = "unknown";
            firstName = string.Empty;
            age = 0;
        }

        // Constructor with four arguments
        public Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lname = lastName;
            fname = firstName;
            anAge = age;
        }

        // Constructor with 3 arguments
        public Person(string id, string lname, string fname)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
        }

        // Overrides toString()
        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public virtual int GetSleepAmt()
        {
            return 8;
        }

    }
}

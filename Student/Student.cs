using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace StudentNamespace
{
    public class Student : Person
    {
        private string major;

        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        private int studentId;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public Student()
            : base()
        {
            major = "unknown";
            studentId = 0;
        }

        // Constructor that sends arguments to the base class
        public Student(string id, string fname, string lname, string maj, int sId)
            : base(id, lname, fname)
        {
            major = maj;
            studentId = sId;
        }

        public override int GetSleepAmt()
        {
            return 6;
        }

        // Using the base keyword calls the overridden 
        // GetSleepAmt() method of the Person class
        public int CallOverriddenGetSleepAmt()
        {
            return base.GetSleepAmt();
        }

    }
}

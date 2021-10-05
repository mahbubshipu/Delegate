using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Student
    {
        public string FisrtName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Student(string fname, string mname, string lname)
        {
            FisrtName = fname;
            MiddleName = mname;
            LastName = lname;
        }
        public Student(string fname,string lname)
        {
            FisrtName = fname;
           
            LastName = lname;
        }
        //public Student()
        //{

        //}
        public string GetName()
        {
            string fullName = FisrtName + " " + MiddleName + " " + LastName;
            return fullName;
        }
    }
}

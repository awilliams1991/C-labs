using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace ClassesLibrary
{
    public class Student//only do 1-4 tonight
    {

        /*
         * 1. Student
        a. firstName – string
        b. lastName – string
        c. id – string
        d. gpa – float
         * */



        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end public FirstName
        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end public LastName

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }//get string ID

        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }//end public Float

        //ctors

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;

        }//FQCTOR

        public Student() { }//empty formatting

        //methods
        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName}\n{Id} with a gpa of {Gpa}");
        }
    }//end class Student
}//end namespace

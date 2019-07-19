using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace ClassesLibrary
{
    public class Customer
    {
        /*
         * Customer
a. customerId – string
b. firstName – string
c. lastName – string
d. contactInformation – ContactInfo
         * */
         


        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo CustomerContact { get; set; }
      
        public Customer(string customerId, string firstName, string lastName, ContactInfo customerContact)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            CustomerContact = customerContact;
        }//FQCTOR
        public Customer() { }//default

        public override string ToString()
        {
            /*
            string infoNeeded = "";
            foreach (ContactInfo customerContact in CustomerContact)
            {
                infoNeeded += customerContact + "\n";
            }//end foreach
            */
            return string.Format("{0}\n{1}\nCustomer ID: {2}\nCustomer Contact Info: {3}\n", 
                LastName, FirstName, CustomerId, CustomerContact);
        }


    }//end class
}//end namespace

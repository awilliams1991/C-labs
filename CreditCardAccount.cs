using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        /*
         * 6. CreditCardAccount
a. accountNumber – int
b. customerInfo – Customer
c. balance – decimal
d. isPastDue – bool
e. annualInterestRate – decimal
         * */
        public bool _isPastDue;


        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public decimal AnnualInterstRate { get; set; }
        public bool IsPastDue
        {
            get { return _isPastDue; }
            set { _isPastDue = value; }
        }
          

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterstRate = annualInterestRate;

        }//FQCTOR
        public CreditCardAccount() { }//default ctor

        public override string ToString()
        {
           
           
            return string.Format("{0}\n{1}\n{2}\n{3}\n Annual interest rate: {4}%\n",
                AccountNumber, 
                CustomerInfo, 
                Balance, 
                IsPastDue ? "Account is overdue" : "Account up to date", 
                AnnualInterstRate);
        }//end tostring

    }//end class
}//end namespace

//Name: Devon Henry
//Class: 1322LW02
//Lab4
using System;
namespace L_Lab4.Properties
{
    public class SavingsAccount: BankAccount
    {

         double interest;
        double interestCalculated;

        public SavingsAccount() : base()
        {
            interest = 1.5;
            interestCalculated = 654;
           
        }
        public SavingsAccount(double interest, double interestCalculated,double balence, string accountNumber) : base( balence, accountNumber)
        {
            this.interest = interest;
            this.interestCalculated = interestCalculated;

        }
        public void addInterest(double interest2) 
        {
         
            interestCalculated = balence * (1 + interest2);

            deposit(interestCalculated);

        }
        public string ToString()
        {
            return "interest:  " + interest + "\ninterest calculated: " + interestCalculated; 
        }


    }
}

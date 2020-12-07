//Name: Devon Henry
//Class: 1322LW02
//Lab4
using System;

namespace L_Lab4
{
    public class BankAccount
    {
       protected string accountNumber;
       protected double balence;



        public BankAccount()
        {
            accountNumber = "59R45V39VN32IVB";
            balence = 10000;

        }
        public BankAccount(double balence, string accountNumber)
        {
            this.balence = balence;
            this.accountNumber = accountNumber;


        }
        public void setBalence(double balence)
        {
            this.balence = balence;
        }
        public void setaccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public double getBalence()
        {
            return balence;
        }
        public string getAccountNumber()
        {
            return accountNumber;

        }
        public void deposit(double deposit)
        {
            this.balence += deposit;
        }
        public void withdraw(double withdraw)
        {
            this.balence -= withdraw;
        }
        public string ToString() {
            return "Balence: " + balence  + "\nAccount Number: " + accountNumber;
        }





    }
}

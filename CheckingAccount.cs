//Name: Devon Henry
//Class: 1322LW02
//Lab4
using System;
namespace L_Lab4.Properties
{
    public class CheckingAccount: BankAccount
    {
        int deposittimes;
        public CheckingAccount() : base()
        {
            deposittimes = 4;
        }
        public CheckingAccount(double balence, string accountNumber) : base(balence, accountNumber)
        {
            deposittimes = 4;
            this.balence = balence;
        }
        public void withdraw()
        {

            if (deposittimes == 0) {
                balence -= 10;
            }
            else {
                deposittimes--;
            }
        }
        public string ToString()
        {
            return "Deposit Times:  " + deposittimes;
        }

    }
}

//Name: Devon Henry
//Class: 1322LW02
//Lab4
using System;
namespace L_Lab4.Properties
{
    
    public class DriverBank
    {
        public static void Main(string[] args)
        {

            BankAccount bk = new BankAccount();
            SavingsAccount sa = new SavingsAccount();
            int choice = 1;
            while (choice > 0) {
                Console.WriteLine("---MENU---\n0 - Exit\n1 - Create a Checking Account\n2 - Create a Savings Account\n3 - Withdraw\n4 - Deposit\n5 - Check Balence\nPlease Choose an Option:");
              choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        
                    break;
                    case 1:

                        bk = new CheckingAccount();
                        Console.WriteLine("Please Enter Your Initial Balance (Minimum 500):");
                        double balance = Console.Read();
                        bk.setBalence(balance);
                        Console.ReadLine();

                        break;
                    case 2:
                        bk = new SavingsAccount();
                        Console.WriteLine("Please Enter Your Initial Balance (Minimum 1000):");
                        double balance2 = Console.Read();
                        bk.setBalence(balance2);
                        Console.WriteLine("What is the interest rate: ");
                        double interest2 = Console.Read();
                        sa.addInterest(interest2);
                        Console.ReadLine();



                        break;
                    case 3:
                        Console.WriteLine("Enter the amount you would like to withdraw.");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        bk.deposit(withdrawAmount);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter the amount you would like to deposit.");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        bk.deposit(depositAmount);
                        Console.ReadLine();

                        break;
                    case 5:
                   
                        Console.WriteLine(bk.getBalence());
                        Console.WriteLine();
                        Console.ReadLine();
                    break;


                }

        }
        }

    }
}

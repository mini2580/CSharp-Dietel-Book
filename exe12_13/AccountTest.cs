using System;
using System.Collections.Generic;

class AccountTest
{
    static void Main(string[] args)
    {
        // Create an Array for Account objects 
        Account[] accounts = new Account[2];
        accounts[0] = new SavingsAccount(50.0M, 0.04M);
        accounts[1] = new CheckingAccount(200.0m, 2.0M);


        //// Create an object of Account class 
        //var acct = new Account(100.0M);

        //// create an object of savings account and initialize it             
        //var saveacct = new SavingsAccount( 50.0M,0.04M);

        //// Object of checking account 
        //var checkacct = new CheckingAccount(200.0m, 2.0M);

        // Get the Credit and Debit information from base class Account
        // Display the initial Balance 

        foreach (var acct in accounts)
        {
            // check if the account is savingsAccount 
            if (acct is SavingsAccount)
            {
                //create an object of savings account and assign the object of Account class by down casting it 
                var saveacct = (SavingsAccount)acct;

                // Display the initial Balance for savings Account 
                Console.WriteLine($"{saveacct.GetType()}: Initial Balance before Credit :{ saveacct.AcctBalance} ");

                // Calculate the interest for savings account 
                var interest = saveacct.ComputeInterest();
                // Perform the credit operation on the savings Account to add the interest
                saveacct.Credit(interest);
            }
             Console.WriteLine($"{acct.GetType()}: Initial Balance before Credit :{ acct.AcctBalance} ");

                // Perform the credit operation on the Account 
                acct.Credit(10);
                //Balance after crediting the account 
                Console.WriteLine($"{acct.GetType()}: Balance after crediting the account: {acct.AcctBalance} ");

                // Display the initial Balance 
                Console.WriteLine($"{acct.GetType()} : Initial Balance before Debit :{ acct.AcctBalance} ");
                // Perform the Debit operation on the Account
                acct.Debit(50);
                //Balance after Debiting the account 
                Console.WriteLine($"{acct.GetType()} : Balance after Debiting the account: {acct.AcctBalance} ");
            
        }

        //// Getting the Debit credit operations from Savings Account 
        //Console.WriteLine();
        //Console.WriteLine();

        // //Balance after crediting the account 
        // Console.WriteLine($"Savings Account: Balance after crediting the account: {saveacct.CurrentBal()} ");


        // // Checking Account Details 
        // Console.WriteLine();
        // Console.WriteLine();

        // // Display the initial Balance for Checkings Account 
        // Console.WriteLine($"Checkings Account: Initial Balance before Credit :{ checkacct.CurrentBal()} ");

        // //Amount to be debited


        //// Perform the Debit operation on the checkings Account to deduct the fee from the account balance 
        // checkacct.Debit(40);

        // // Getting details of the Debit amount and Fee
        // Console.WriteLine(checkacct.ToString());

        // //Balance after Debiting the account 
        // Console.WriteLine($"Checkings Account: Balance after debiting the account: {checkacct.CurrentBal()} ");

    }
}


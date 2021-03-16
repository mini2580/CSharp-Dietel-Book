using System;
using System.Collections.Generic;
using System.Text;

    public class SavingsAccount : Account
    {
        // Decimal instance variable interest rate (percentage assigned )
         public decimal InterestRate { get; set; }

        //Constrructor to initialize the savings account with balance and interest rate 
        public SavingsAccount(decimal bal, decimal rate ): base(bal)
        {
            InterestRate = rate;
        }
        // Method to calculate the amount of interest earned by  account 
        
        public decimal ComputeInterest()
        {
            return AcctBalance * InterestRate;
        }
        
    }


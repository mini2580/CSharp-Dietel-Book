using System;
using System.Collections.Generic;
using System.Text;

    public class CheckingAccount : Account
    {
        //instance varaiable for fee charged per transaction 
        public decimal Fee { get; set; }

        // Boolean to see if the fee is deducted 

        static private bool IsFeeCharged = false;

        // constructor of CheckingAccount 

        public CheckingAccount(decimal bal , decimal fee_amt):base(bal)
        {
            Fee = fee_amt;
        }

        // Overriding the method Credit 

        public override bool Credit(decimal amount)
        {
            if (Fee > AcctBalance)
            {
                Console.WriteLine("Invalid Fee:Too High");
                return false;
            }
            else
            {
                AcctBalance -= Fee;
                return base.Credit(amount);
                
            }
           
        }
        //Overriding the debit method 

        public override bool Debit(decimal amount) 
        {
            IsFeeCharged = base.Debit(amount);
            if (IsFeeCharged)
            {
                AcctBalance -= Fee;
            }

            return IsFeeCharged;
        }

        public override string ToString() => IsFeeCharged? $"Fee charged: {Fee}": "No Fee charged as No withdrawal";
        

    }


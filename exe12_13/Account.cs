using System;
using System.Collections.Generic;
using System.Text;

    public class Account
    {
        private decimal acctBalance; // Account Balance 
        // Consturctor to provide initial balance 
        public Account(decimal initialbal)
        {
            AcctBalance = initialbal;
        }

        //Property to access the private member account balance 
        public decimal AcctBalance
        {
            get
            {
                return acctBalance;
            }
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(acctBalance)} must be greater that 0");
                }
                else
                {
                    acctBalance = value;
                }
            }
        }

        //Method credit to deposit Money 
        public virtual bool Credit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Provide a valid amount of Money to be Deposited");
                return false;
            }
            else
            {
                AcctBalance += amount;
                return true;
            }
          
        }

        //Method Debit to withdraw money 
        public virtual bool Debit(decimal amount) 
        {
            bool IsWithdrawal = false;
            if (amount > AcctBalance)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
            }
            else
            {
                AcctBalance -= amount;
                IsWithdrawal = true;
            }
            return IsWithdrawal;
        }

        // Method to inform current balance 
        public virtual string CurrentBal() => $"The current Balance is : {AcctBalance}";
        
    }


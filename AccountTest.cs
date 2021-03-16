using System; // directive

class AccountTest
{
    static void Main()
    {

        // ceate Account object 

        Account myAccount = new Account();

        //  myAccount.name = "Mini";  tried to access the private variable ; will give an error 

        Console.WriteLine($"Initial Name is: {myAccount.GetName()}");
        Console.WriteLine($"Initial Balance is: {myAccount.GetBalance()}");

        Console.Write("Enter the Name: ");
        string theName = Console.ReadLine();
        myAccount.SetName(theName);
        Console.WriteLine();
        Console.Write("Enter the Balance: ");
         double theBalance = Double.Parse(Console.ReadLine());
        myAccount.SetBalance(theBalance);
        DisplayAccount(myAccount);

      //  Console.WriteLine($"The name of the Account is : {myAccount.GetName()}");

        //Console.WriteLine($"The Balance of the Account is : {myAccount.GetBalance()}");

    }//end of Main class

    static void DisplayAccount(Account acct)
    {
        Console.WriteLine($"The company {Account.companyName} has the Account  : {acct.GetName()}");// accessing the static member using class name 

        Console.WriteLine($"The Balance of the Account is : {acct.GetBalance()}");

    }
}
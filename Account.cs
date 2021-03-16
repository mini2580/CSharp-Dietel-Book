
using System; 

class Account{

    private string name; // instance variable
    private double balance; //instance variable
    public static string companyName = "Learn Prodigy"; // static member ; one copy through out ; no seperate copies as per the instance 

    // property for companyName

    public string CompanyName
    {
        get { return companyName; }
    }

    //Set method - will set the value 
    public void SetName(string accountName)
    {
        name = accountName;
    }// set method end

    // Get method will return the value to the client
    public string GetName()
    {
        return name;
    }// Get Method end

    public void SetBalance(double bal)
    {
        if (bal >= 0)
        {
            balance = bal;
        }
        else
        {
            Console.WriteLine("Balance must be a positive number");
        }
    }// end of SetBAlance Method 

    public double GetBalance()
    {

        return balance;
    }
}
namespace Account_Manager.Models;

internal class Customer_Account
{
    public string? bank_name;
    public long customer_accountNo;
    public String customer_name;
    
    public Customer_Account(long customer_accountNo, String customer_name)
    {
        this.customer_accountNo = customer_accountNo;
        this.customer_name = customer_name;
    }

    /// <Summary>
    /// This method prints all the information about the Customer_Account
    /// </Summary>
    public void PrintInfo()
    {
        Console.WriteLine($"Bank Name is {bank_name}");
        Console.WriteLine($"Account Number is {customer_accountNo}");
        Console.WriteLine($"Customer Name is {customer_name}");
    }
}

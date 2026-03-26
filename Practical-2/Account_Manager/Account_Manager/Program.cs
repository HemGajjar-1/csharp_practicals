namespace Account_Manager;

class InitialClass{
    public static void Main(String[] args)
    {
        // Here we are creating the object of Customer_Account class
        Customer_Account c1 = new Customer_Account(12345,"Hem Gajjar");
        
        c1.bank_name = "ICICI Bank";
        c1.PrintInfo();
    }
}
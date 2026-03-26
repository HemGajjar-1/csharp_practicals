namespace University_Management_System.MyClasses;

//This is another inherited class
internal class Professor : Person, IPayable
{
    public double Salary { get; set; }
    public Professor(int id, string name, Address address, double salary) : base(id, name, address)
    {
        Salary = salary;
    }

    /// <summary>
    /// Displaying information about professor
    /// </summary>
    public override void DisplayInfo()
    {
        Console.WriteLine($"Professor Name : {Name} , City : {Address.City}");
    }

    /// <summary>
    /// Returning salary of professor
    /// </summary>
    public double CalculatePayment()
    {
        return Salary;
    }
}

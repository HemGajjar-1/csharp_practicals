namespace University_Management_System.MyClasses;

// Encapsulation
internal class Address
{
    public string City { get; set; }
    public string State { get; set; }
    public Address(string city, string state)
    {
        City = city;
        State = state;
    }
}

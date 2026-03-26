namespace University_Management_System.MyClasses;

// This class demonstrates Abstraction 
internal abstract class Person
{
    private int id;
    private string? name;
    public Address Address { get; set; }
    public int Id
    {
        get { return id; }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Invalid ID");
            }
            id = value;
        }
    }
    public string? Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be empty");
            }
            name = value;
        }
    }
    public Person(int id, string name, Address address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
    // This is an Abstract method
    public abstract void DisplayInfo();
}

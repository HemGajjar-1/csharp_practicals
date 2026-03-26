using University_Management_System.Interfaces;

namespace University_Management_System.MyClasses;

// This demonstrates Inheritance and Method Overriding
internal class Student : Person, IPayable
{
    public double TutionFees { get; set; }
    public Student(int id, string name, Address address, double fees) : base(id, name, address)
    {
        TutionFees = fees;
    }

    /// <summary>
    /// Here is the method which is being overridden 
    /// </summary>
    public override void DisplayInfo()
    {
        Console.WriteLine($"Student Name : {Name} , City : {Address.City}");
    }

    /// <summary>
    /// Returning the tution fees of the student
    /// </summary>
    public double CalculatePayment()
    {
        return TutionFees;
    }
}

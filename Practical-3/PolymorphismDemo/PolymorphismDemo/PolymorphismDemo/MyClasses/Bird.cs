namespace PolymorphismDemo.MyClasses;

internal class Bird
{
    /// <Summary>
    /// Here we are making Voice() as virtual so that we can override it in child class
    /// </Summary>
    public virtual void Voice()
    {
        Console.WriteLine("Turr Turr...");
    }
}

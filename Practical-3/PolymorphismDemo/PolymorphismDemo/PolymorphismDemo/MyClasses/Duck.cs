namespace PolymorphismDemo.MyClasses;

internal class Duck : Bird
{
    /// <Summary>
    /// Here we are overriding the method voice
    /// </Summary>
    public override void Voice()
    {
        Console.WriteLine("Quack Quack...");
    }
}

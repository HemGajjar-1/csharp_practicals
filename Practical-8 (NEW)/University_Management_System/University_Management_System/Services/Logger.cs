namespace University_Management_System.Services;

//This demonstrates Sealed Class
internal sealed class Logger
{
    /// <summary>
    /// Printing the log
    /// </summary>
    public void Log(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
}

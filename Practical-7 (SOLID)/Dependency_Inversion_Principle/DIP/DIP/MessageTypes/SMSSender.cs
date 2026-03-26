namespace DIP.MessageTypes;

// SMSSender is a low level module
internal class SMSSender : IMessageSender
{
    /// <summary>
    /// Sending Message by email
    /// </summary>
    public void SendMessage(string message)
    {
        Console.WriteLine($"[SMS Sent] {message}");
    }
}
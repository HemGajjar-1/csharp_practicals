using DIP.Interfaces;

namespace DIP.MessageTypes;

// EmailSender is a low level module
internal class EmailSender : IMessageSender
{
    /// <summary>
    /// Sending Message by email
    /// </summary>
    public void SendMessage(string message)
    {
        Console.WriteLine($"[Email Sent] {message}");
    }
}

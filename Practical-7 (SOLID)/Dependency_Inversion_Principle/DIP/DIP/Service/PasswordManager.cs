namespace DIP.Service;

// PasswordManager is a high level module
// Here as we can see we are not directly creating the object of class EmailSender or SMSSender but we are using the reference of 
// Interface and then getting the Message type in the constructor.
internal class PasswordManager
{
    private IMessageSender _messageSender;
    public PasswordManager(IMessageSender _messageSender)
    {
        this._messageSender = _messageSender;
    }
    public void SendReminder()
    {
        _messageSender.SendMessage("Your password reset code is 287045");
    }
}

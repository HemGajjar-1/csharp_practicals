namespace DIP;

class InitialClass
{
    public static void Main(String[] args)
    {
        IMessageSender emailSender = new EmailSender();
        PasswordManager emailReminder = new PasswordManager(emailSender);
        emailReminder.SendReminder();

        IMessageSender smsSender = new SMSSender();
        PasswordManager smsReminder = new PasswordManager(smsSender);
        smsReminder.SendReminder();
    }
}
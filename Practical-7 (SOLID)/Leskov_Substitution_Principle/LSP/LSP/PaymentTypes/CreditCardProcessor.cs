namespace LSP.PaymentTypes;

internal class CreditCardProcessor : IChargeable, IRefundable
{
    /// <summary>
    /// Processing Payment by Credit Card
    /// </summary>
    public void ProcessPayment(string orderID, int amount)
    {
        Console.WriteLine($"[Credit-Card] Charging {amount} for Order ID {orderID}");
    }

    /// <summary>
    /// Processing Refund by Credit Card
    /// </summary>
    public void RefundPayment(string orderID, int amount)
    {
        Console.WriteLine($"[Credit-Card] Refunding {amount} for Order ID {orderID}");
    }
}

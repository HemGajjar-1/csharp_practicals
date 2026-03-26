namespace LSP.PaymentTypes;

internal class PayPalProcessor : IChargeable, IRefundable
{
    /// <summary>
    /// Processing Payment by PayPal
    /// </summary>
    public void ProcessPayment(string orderID, int amount)
    {
        Console.WriteLine($"[Pay-Pal] Charging {amount} for Order ID {orderID}");
    }

    /// <summary>
    /// Processing Refund by PayPal
    /// </summary>
    public void RefundPayment(string orderID, int amount)
    {
        Console.WriteLine($"[Pay-Pal] Refunding {amount} for Order ID {orderID}");
    }
}
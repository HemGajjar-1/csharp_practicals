using LSP.Interfaces;

namespace LSP.PaymentTypes;

internal class PromoCodeProcessor : IChargeable
{
    /// <summary>
    /// Processing Payment by Promo Code
    /// </summary>
    public void ProcessPayment(string orderID, int amount)
    {
        Console.WriteLine($"[Promo Code] Charging {amount} for Order ID {orderID}");
    }

}
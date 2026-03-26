namespace LSP.Services;

internal class CheckoutService
{
    public void CompleteCheckout(string orderID, int totalAmount, IEnumerable<IChargeable> paymentMethods)
    {
        Console.WriteLine("--------------- Starting Payment ---------------");
        foreach (var payment in paymentMethods)
        {
            payment.ProcessPayment(orderID, totalAmount);
        }
        Console.WriteLine("--------------- Payment Completed ---------------");
    }
}

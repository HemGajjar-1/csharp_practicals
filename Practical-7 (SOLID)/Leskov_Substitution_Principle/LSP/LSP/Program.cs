namespace LSP;

class InitialClass
{
    public static void Main(String[] args)
    {
        CheckoutService obj1 = new CheckoutService();
        RefundService obj2 = new RefundService();

        // Creating list of all the objects that implement IChargeable
        List<IChargeable> checkoutPayments = new List<IChargeable>
        {
            new CreditCardProcessor(),
            new PromoCodeProcessor()
        };

        obj1.CompleteCheckout("ORDER-1", 1000, checkoutPayments);

        // Creating list of all the objects that implement IRefundable
        List<IRefundable> refundPayments = new List<IRefundable>
        {
            new CreditCardProcessor(),
            new PayPalProcessor()
        };

        obj2.CompleteRefund("ORDER-1", 1000, refundPayments);
    }
}
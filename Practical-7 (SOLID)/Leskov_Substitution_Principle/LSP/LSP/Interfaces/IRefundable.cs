namespace LSP.Interfaces;

internal interface IRefundable
{
    void RefundPayment(string orderID, int amount);
}



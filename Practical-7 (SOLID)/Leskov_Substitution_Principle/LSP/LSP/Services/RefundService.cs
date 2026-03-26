using LSP.Interfaces;

namespace LSP.Services;

internal class RefundService
{
    public void CompleteRefund(string orderID, int refundAmount, IEnumerable<IRefundable> refundMethods)
    {
        Console.WriteLine("--------------- Starting Refund ---------------");
        foreach (var refund in refundMethods)
        {
            refund.RefundPayment(orderID, refundAmount);
        }
        Console.WriteLine("--------------- Refund Completed ---------------");
    }
}

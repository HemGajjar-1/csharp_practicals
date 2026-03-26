namespace LSP.Interfaces;

internal interface IChargeable
{
    void ProcessPayment(string orderID, int amount);
}

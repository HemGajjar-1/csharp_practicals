namespace OCP.Product_Types;

internal class Electronics : TaxSystem
{
    public double CalculateTax(Product p) => p.Price * 0.15;
}

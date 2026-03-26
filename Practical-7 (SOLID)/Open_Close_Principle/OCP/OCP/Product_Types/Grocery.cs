namespace OCP.Product_Types;

internal class Grocery : TaxSystem
{
    public double CalculateTax(Product p) => p.Price * 0.05;
}

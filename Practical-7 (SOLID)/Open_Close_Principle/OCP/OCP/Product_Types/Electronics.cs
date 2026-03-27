namespace OCP.Product_Types;

internal class Electronics : ITaxSystem
{
    public double CalculateTax(Product p) => p.Price * 0.15;
}

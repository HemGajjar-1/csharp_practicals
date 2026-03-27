namespace OCP.Product_Types;

internal class Clothings : ITaxSystem
{
    public double CalculateTax(Product p) => p.Price * 0.10;
}

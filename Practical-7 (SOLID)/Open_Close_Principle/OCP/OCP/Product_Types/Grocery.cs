namespace OCP.Product_Types;

internal class Grocery : ITaxSystem
{
    public double CalculateTax(Product p) => p.Price * 0.05;
}

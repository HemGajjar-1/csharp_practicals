using OCP.Interface;
using OCP.Models;

namespace OCP.Product_Types;

internal class Clothings : TaxSystem
{
    public double CalculateTax(Product p) => p.Price * 0.10;
}

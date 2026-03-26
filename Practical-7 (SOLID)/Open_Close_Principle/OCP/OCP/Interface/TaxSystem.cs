using OCP.Models;

namespace OCP.Interface;

internal interface TaxSystem
{
    double CalculateTax(Product p);
}

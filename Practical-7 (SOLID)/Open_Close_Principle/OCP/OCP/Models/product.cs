using OCP.Enums;

namespace OCP.Models;

internal class Product
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public ProductCategory Category { get; set; }

}

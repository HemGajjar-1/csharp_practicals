namespace OCP;

class InitialClass
{
    public static void Main(String[] args)
    {
        // Clothing object
        var c1 = new Product() { Name = "Jeans", Price = 1000, Category = ProductCategory.Clothings };
        TaxCalculator tc1 = new TaxCalculator(new Clothings());
        Console.WriteLine($"The tax for product {c1.Name} - {c1.Category} is {tc1.CalculateTax(c1)}");

        // Electronic object
        var e1 = new Product() { Name = "Fridge", Price = 10000, Category = ProductCategory.Electronics };
        TaxCalculator tc2 = new TaxCalculator(new Electronics());
        Console.WriteLine($"The tax for product {e1.Name} - {e1.Category} is {tc2.CalculateTax(e1)}");

        // Grocery object
        var g1 = new Product() { Name = "Vegetables", Price = 700, Category = ProductCategory.Groceries };
        TaxCalculator tc3 = new TaxCalculator(new Grocery());
        Console.WriteLine($"The tax for product {g1.Name} - {g1.Category} is {tc3.CalculateTax(g1)}");
    }
}
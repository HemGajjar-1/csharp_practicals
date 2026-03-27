namespace OCP.Services;

internal class TaxCalculator
{
    private ITaxSystem _taxsystem;
    public TaxCalculator(ITaxSystem ts)
    {
        _taxsystem = ts;
    }

    /// <summary>
    /// Calculating the tax
    /// </summary>
    public double CalculateTax(Product p)
    {
        return _taxsystem.CalculateTax(p);
    }
}

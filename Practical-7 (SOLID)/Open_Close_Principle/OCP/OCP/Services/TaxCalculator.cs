namespace OCP.Services;

internal class TaxCalculator
{
    private TaxSystem _taxsystem;
    public TaxCalculator(TaxSystem ts)
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

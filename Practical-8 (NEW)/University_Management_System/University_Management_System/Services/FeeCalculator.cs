namespace University_Management_System.Services;

// This demonstrate Method Overloading
internal class FeeCalculator
{
    /// <summary>
    /// To just get fees
    /// </summary>
    public double CalculateFee(double baseFee)
    {
        return baseFee;
    }

    /// <summary>
    /// To get fees after getting discount
    /// </summary>
    public double CalculateFee(double baseFee, double discount)
    {
        return baseFee - discount;
    }

    /// <summary>
    /// To get fees after getting discount and adding tax
    /// </summary>
    public double CalculateFee(double baseFee, double discount, double tax)
    {
        return (baseFee - discount) + tax;
    }
}

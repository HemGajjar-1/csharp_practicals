namespace AbstractionDemo.MyClasses;

internal class Laptop
{
    private string? brand;
    private string? model;
    
    public string? Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string? Model
    {
        get { return model; }
        set { model = value; }
    }

    /// <Summary>
    /// This method prints the brand and model
    /// </Summary>
    public void LaptopDetails()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
    }

    /// <Summary>
    /// This method is kept private to understand that private methods 
    /// cannot be accessed outside the class
    /// </Summary>
    private void MotherBoardInfo()
    {
        Console.WriteLine("MotherBoard Information");
    }
}

namespace AbstractionDemo;

class InitialClass
{
    public static void Main(String[] args)
    {
        Laptop l1 = new Laptop();

        l1.Brand = "HP";
        l1.Model = "Victus Series";

        l1.LaptopDetails();

        // We cannot access MotherBoardInfo() method because its private
        //l1.MotherBoardInfo();
    }
}
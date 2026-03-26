namespace Inheritance;

class InitialClass
{
    public static void Main(String[] args)
    {
        // Creating object of Team class
        Team t1 = new Team("Chennai Super Kings");

        Console.WriteLine(t1.printInfo());
    }
}
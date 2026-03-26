namespace PolymorphismDemo;

class InitialClass
{
    public static void Main(String[] args)
    {
        // Parent Reference and Parent Instance
        Bird myBird = new Bird();
        
        // Parent Reference and Child Instance
        Bird myDuck = new Duck();

        myBird.Voice();
        myDuck.Voice();
    }
}
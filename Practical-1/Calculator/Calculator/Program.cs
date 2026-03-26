namespace Calculator;

class InitialClass
{
    public static void Main(String[] args)
    {
        try
        {
            // Enter the first number
            Console.Write("Enter first number:");
            decimal first = Convert.ToDecimal(Console.ReadLine());
            
            // Enter the second number
            Console.Write("Enter second number:");
            decimal second = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"The sum of {first} and {second} is {first + second}");
            
            Console.WriteLine($"The subtraction of {first} and {second} is {first - second}");
            
            Console.WriteLine($"The multiplication of {first} and {second} is {first * second}");
            
            Console.WriteLine($"The division of {first} and {second} is {first / second}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
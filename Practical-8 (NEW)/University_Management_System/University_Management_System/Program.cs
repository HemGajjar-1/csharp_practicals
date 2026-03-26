namespace University_Management_System;

public class InitialClass
{
    public static void Main(String[] args)
    {
        try
        {
            Address address = new Address("Ahmedabad", "Gujarat");

            Student student = new Student(1, "Hem", address, 50000);
            Professor professor = new Professor(2, "Dr. Gajjar", address, 90000);

            student.DisplayInfo();
            professor.DisplayInfo();

            FeeCalculator calculator = new FeeCalculator();

            Console.WriteLine("Fee: " + calculator.CalculateFee(50000));
            Console.WriteLine("Fee with discount: " + calculator.CalculateFee(50000, 5000));

            Logger logger = new Logger();
            logger.Log("Application executed successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }
}
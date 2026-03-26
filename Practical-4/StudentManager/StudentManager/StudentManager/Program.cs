namespace StudentManager;

class InitialClass
{
    public static decimal GetMaxMarks(decimal[] marks)
    {
        decimal max_mark = marks[0];
        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > max_mark)
            {
                max_mark = marks[i];
            }
        }
        return max_mark;
    }
    public static decimal GetMinMarks(decimal[] marks)
    {
        decimal min_mark = marks[0];
        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] < min_mark)
            {
                min_mark = marks[i];
            }
        }
        return min_mark;
    }
    public static void Main(String[] args)
    {
        try
        {
            Student s1 = new Student();

            Console.Write("Enter Student Name: ");
            s1.Name = (Console.ReadLine());

            // Getting marks of 5 subjects from user
            Console.WriteLine("Enter marks of 5 subject: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} :");
                s1.Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }

            // The menu for the user:
            Console.WriteLine("\n1 - Aggregate");
            Console.WriteLine("2 - MinMark");
            Console.WriteLine("3 - MaximumMark");
            Console.WriteLine("4 - Grade");
            Console.Write("\nChoose Option::");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch ((Options)choice)
            {
                case Options.Aggregate:
                    Console.WriteLine($"Name of the student: {s1.Name}");
                    Console.WriteLine($"Average Marks of the student: {s1.CalculateAverageMarks()}");
                    break;

                case Options.MinMark:
                    Console.WriteLine($"Minimum marks of student is {GetMinMarks(s1.Marks)}");
                    break;

                case Options.MaximumMark:
                    Console.WriteLine($"Maximum marks of student is {GetMaxMarks(s1.Marks)}");
                    break;

                case Options.Grade:
                    decimal average = s1.CalculateAverageMarks();
                    Console.WriteLine($"Grade of the student is {s1.CalculateGrade(average)}");
                    break;

                default:
                    Console.WriteLine("Wrong Option Selected");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        
    }
}
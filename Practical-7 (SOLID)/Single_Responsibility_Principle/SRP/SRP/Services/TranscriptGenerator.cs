using SRP.MyClasses;

namespace SRP.Services;

internal class TranscriptGenerator
{
    private GPA_Calculator gpa_cal;

    public TranscriptGenerator(GPA_Calculator g)
    {
        gpa_cal = g;
    }

    /// <summary>
    /// Printing details
    /// </summary>
    public void PrintTranscript(Student student)
    {
        Console.WriteLine($"Name of the student:{student.Name}");
        Console.WriteLine("Courses Details ::");
        foreach (KeyValuePair<string, int> item in student.CourseAndGrade)
        {
            Console.WriteLine($"{item.Key} --> {item.Value}");
        }
        Console.WriteLine($"GPA of {student.Name} is {gpa_cal.calculate_gpa(student)}");
    }
}

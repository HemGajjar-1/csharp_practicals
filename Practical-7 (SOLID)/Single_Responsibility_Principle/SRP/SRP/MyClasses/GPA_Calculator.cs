namespace SRP.MyClasses;

internal class GPA_Calculator
{
    /// <summary>
    /// Here we care calculating the GPA
    /// </summary>
    public double calculate_gpa(Student student)
    {
        return student.CourseAndGrade.Values.Average();
    }
}

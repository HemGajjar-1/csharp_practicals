namespace SRP.MyClasses;

internal class Student
{
    public string? Name { get; set; }
    public Dictionary<string, int> CourseAndGrade = new Dictionary<string, int>();
    
    /// <summary>
    /// Here we are giving default value for grade
    /// </summary>
    public void EnrollCourse(string courseName)
    {
        CourseAndGrade[courseName] = 0;
    }

    /// <summary>
    /// Here we are assigning grade for course
    /// </summary>
    public void AssignGrade(string courseName, int gradeToAssign)
    {
        CourseAndGrade[courseName] = gradeToAssign;
    }
}

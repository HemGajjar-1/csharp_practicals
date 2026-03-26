namespace StudentManager.MyClasses;

internal class Student
{
    public string? Name;
    public decimal[] Marks = new decimal[5];
    static decimal AverageMarks;
    public decimal CalculateAverageMarks()
    {
        decimal sum = 0;
        foreach (decimal i in Marks)
        {
            sum += i;
        }
        return (sum / Marks.Length);
    }
    public string CalculateGrade(decimal marks)
    {
        return marks switch
        {
            > 90 => "A",
            > 80 => "B",
            > 70 => "C",
            _ => "D"
        };
    }
}

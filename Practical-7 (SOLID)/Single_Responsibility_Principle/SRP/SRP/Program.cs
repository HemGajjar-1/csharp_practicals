using SRP.MyClasses;
using SRP.Services;

namespace SPR;

public class InitialClass
{
    public static void Main(String[] args)
    {
        Student hem = new Student() { Name = "Hem" };

        hem.EnrollCourse("Data Structures");
        hem.AssignGrade("Data Structures", 80);
        hem.AssignGrade("COA", 70);
        hem.AssignGrade("Compiler Design", 85);
        hem.AssignGrade("Theory Of Computation", 60);

        GPA_Calculator gpacal = new GPA_Calculator();

        TranscriptGenerator tg = new TranscriptGenerator(gpacal);

        tg.PrintTranscript(hem);
    }
}
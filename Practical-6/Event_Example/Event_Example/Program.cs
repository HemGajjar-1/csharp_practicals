using Event_Example.BusinessLogic;

namespace Event_Example;

class InitialClass
{
    public static void Main(String[] args)
    {
        ProcessBusinessLogic obj = new ProcessBusinessLogic();
        InitialClass cur = new InitialClass();
        obj.ProcessCompleted += cur.bl_ProcessCompleted;
        obj.StartProcess();
    }

    /// <summary>
    /// The below method is invoked by the event
    /// </summary>
    public void bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked...");
    }
}
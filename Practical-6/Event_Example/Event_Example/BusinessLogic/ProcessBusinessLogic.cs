namespace Event_Example.BusinessLogic;

internal class ProcessBusinessLogic
{
    public event Action? ProcessCompleted;

    /// <summary>
    /// The below method is used to perform some task and then call OnProcessCompleted() method
    /// </summary>
    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        Thread.Sleep(5000);
        OnProcessCompleted();
    }

    /// <summary>
    /// In the method below we are invoking the event
    /// </summary>
    protected void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}

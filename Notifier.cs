public class Notifier
{
    public void Subscribe(MyTask myTask)
    {
        myTask.StatusChange += HandleStatusChange;
    }

    private void HandleStatusChange(string taskName, string status)
    {
        Console.WriteLine($"Task \"{taskName}\" has changed status to \"{status}\"");
    }
}
public delegate void StatusChangeHandler(string taskName, string newStatus);

public class MyTask
{
    public string Name { get; private set; }
    public string _status;
    public event StatusChangeHandler StatusChange;

    public MyTask(string name)
    {
        Name = name;
    }

    public void UpdateStatus(string newStatus)
    {
        if (_status != newStatus)
        {
            _status = newStatus;
            OnStatusChange(newStatus);
        }
    }
    protected virtual void OnStatusChange(string newStatus)
    {
        if (StatusChange != null)
        {
            StatusChange.Invoke(Name, newStatus);
        }
    }
}
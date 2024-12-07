public class Notifier
{
    public void Subscribe(MyTask myTask)
    {
        myTask.StatusChange += HandleStatusChange;
    }
    public void SubscribeInTemparature(TemperatureSensor temperatureSensor)
    {
        temperatureSensor.TemperatureExceeded += OnTemperatureThresholdExceeded;
    }
    private void HandleStatusChange(string taskName, string status)
    {
        Console.WriteLine($"Task \"{taskName}\" has changed status to \"{status}\"");
    }
    private void OnTemperatureThresholdExceeded(int currentTemperature)
    {
        Console.WriteLine($"Warning! Temperature exceeded the threshold: {currentTemperature}°C");
    }
}
public delegate void TemperatureThresholdExceeded(int currentTemperature);
public class TemperatureSensor
{
    public int Temperature { get; private set; }
    public const int TemperatureThreshor = 35;
    public event TemperatureThresholdExceeded TemperatureExceeded;

    public void SetTemparature(int temperature)
    {
        Temperature = temperature;
        if (Temperature > TemperatureThreshor)
        {
            OnTemperatureExceeded(temperature);
        }
    }
    protected virtual void OnTemperatureExceeded(int temperature)
    {
        TemperatureExceeded?.Invoke(temperature);
    }
}
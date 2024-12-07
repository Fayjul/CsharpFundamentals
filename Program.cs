/*
class Program
{
    static void Main(string[] args)
    {
        /*
        MyTask myTask = new MyTask("Complete Assignment");
        MyTask myTask1 = new MyTask("Prepare Presentation");

        Notifier notifier = new Notifier();
        notifier.Subscribe(myTask);
        notifier.Subscribe(myTask1);

        myTask.UpdateStatus("In Progress");
        myTask.UpdateStatus("Complete");

        myTask1.UpdateStatus("In Progress");
        myTask1.UpdateStatus("On Hold");
        myTask1.UpdateStatus("Complete");/ // There is an multiline comment.

        TemperatureSensor temperatureSensor = new TemperatureSensor();
        Notifier notifier = new Notifier();
        notifier.SubscribeInTemparature(temperatureSensor);
        temperatureSensor.SetTemparature(30);
        temperatureSensor.SetTemparature(40);
        Console.ReadLine();
    }
}
*/

class Delegate
{
    public delegate int DoMath(int a, int b);
    public int AddTwoNumber(int a, int b)
    {
        return a + b;
    }
    public static void Main(string[] args)
    {
        Delegate del = new Delegate();
        DoMath adding = new DoMath(del.AddTwoNumber);
        Console.WriteLine(adding(1, 2));
    }
}
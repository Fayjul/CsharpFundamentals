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
/*
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
*/

class Program
{
    static void Main(string[] args)
    {
        Button button = new Button();
        Listener listener = new Listener();

        // Subscribe the listener to the button's event
        button.Clicked += listener.OnButtonClicked;

        // Simulate button click
        button.Click();
        button.Click();

        Console.ReadLine();
    }
}

class Button
{
    // Declare the event using EventHandler (no custom arguments)
    public event EventHandler Clicked;

    public void Click()
    {
        Console.WriteLine("Button was clicked!");
        OnClicked(); // Raise the event
    }

    protected virtual void OnClicked()
    {
        // Invoke the event if there are any subscribers
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

class Listener
{
    public void OnButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Listener: Button click event received!");
    }
}

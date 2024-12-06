class Program
{
    static void Main(string[] args)
    {
        MyTask myTask = new MyTask("Complete Assignment");
        MyTask myTask1 = new MyTask("Prepare Presentation");

        Notifier notifier = new Notifier();
        notifier.Subscribe(myTask);
        notifier.Subscribe(myTask1);

        myTask.UpdateStatus("In Progress");
        myTask.UpdateStatus("Complete");

        myTask1.UpdateStatus("In Progress");
        myTask1.UpdateStatus("On Hold");
        myTask1.UpdateStatus("Complete");

        Console.ReadLine(); // Keep console open
    }
}

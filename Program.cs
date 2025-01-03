﻿// Basic of linq
/*
public class LinQExample
{
    public static void Main(string[] args)
    {
        int[] nums = [0, 1, 2, 3, 1];
        var res = from a in nums where a < 3 orderby a select a + 3;
        foreach (int i in res)
            Console.WriteLine(i);
    }
}
*/

// Patient Example  of linq
/* public class LinQExample
{
    public static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient { Name = "Adib", Age = 5 },
            new Patient { Name = "Afif", Age = 1 }
        };

        var myPatients = from patient in patients
                         where patient.Age > 2
                         select patient;
        foreach (var patient in myPatients)
        {
            Console.WriteLine($"The Name of patient is {patient.Name}");
        }

        Console.WriteLine("");
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
        Console.WriteLine("Pairs where a < b:");
        foreach (var pair in pairs)
        {
            Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
        }
    }
} */

public class IEnumerableVSIEnumeratro
{
    public static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient { Name = "Adib", Age = 5 },
            new Patient { Name = "Afif", Age = 1 }
        };


        /* foreach (var patient in patients)
        {
            Console.WriteLine("Name = ", patient.Name, " Age = ", patient.Age);
        } */
        var method = patients.GetEnumerator();

        IEnumerable<Patient> IenumerablePatients = patients;
        IEnumerator<Patient> IenumeratorPatient = patients.GetEnumerator();

        foreach (var patient in IenumerablePatients)
        {
            Console.WriteLine($"Name = {patient.Name}, Age = {patient.Age}");
        }
        Console.WriteLine("IEnumerable Complite");

        while (IenumeratorPatient.MoveNext())
        {
            Console.WriteLine(IenumeratorPatient.Current.Name);
        }

    }
}

// Deferred Execution in Lin Q

/*
LINQ queries are not executed when they are defined but when they are iterated over
(e.g., using a foreach loop). This is called deferred execution.
*/
/* public class LinQExample
{
    public static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 1]; // Query is not executed here
        var query = from num in nums where num > 3 select num;
        Console.WriteLine(query);
        foreach (int q in query)
        {
            Console.WriteLine(q);// Query is executed here, Deferred Execution.
        }

        var queries = nums.Where(q => q > 2).ToList(); // Query Executed Here. It's call Immediate Execution.

        Console.WriteLine(queries);

    }
} */

/*  // Delegates and Event
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
/* // Only Delegate
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
/*   // Only Event
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
*/
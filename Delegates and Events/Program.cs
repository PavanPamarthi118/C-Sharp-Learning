// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//--------------------------------------- Delegate -----------------------------------------//

//Delegate is a type safe function pointer ,it holds reference of a method and calls the method for execution


delegate void MyDelegate(string message);  // Declare a delegate

class Program
{
    static void PrintMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    static void Main()
    {
        MyDelegate del = PrintMessage;  // Assign method to delegate
        del.Invoke("Hello, Delegates!");  // Invoke delegate
        del("Hello, Delegates!");  // Invoke delegate
    }
}

/*
How it Works?

MyDelegate defines a delegate that takes a string parameter.
PrintMessage method is assigned to the delegate.
Calling del("Hello") invokes PrintMessage.
*/

// Multicast Delegate ---> A delegate can hold multiple method references.


delegate void Notify(); // Declare a delegate

class Program2
{
    static void ShowMessage() => Console.WriteLine("Message displayed!");
    static void ShowAlert() => Console.WriteLine("Alert displayed!");

    static void Main()
    {
        Notify del = ShowMessage;
        del += ShowAlert;  // Add another method

        del();  // Calls both methods
    }
}


//--------------------------------------- Event -----------------------------------------//

/*
An event in C# is a mechanism that enables a class to notify other classes or objects when something happens. 
It follows the Observer design pattern and is used for implementing publish-subscribe communication between objects.

How Events Works?

Publisher (Event Source): Defines and raises the event.
Subscriber (Event Listener): Responds to the event by attaching a handler method

Defining an Event
Events in C# are based on delegates. A delegate is a type that references a method.
 */


public class Button
{
    // Define an event using a delegate
    public event EventHandler Clicked;

    // Method to trigger the event
    public void Click()
    {
        Console.WriteLine("Button Clicked!");
        Clicked?.Invoke(this, EventArgs.Empty); // Raise the event
    }
}

public class Program3
{
    static void Main()
    {
        Button button = new Button();

        // Subscribe to the event
        button.Clicked += Button_ClickHandler;

        button.Click(); // This will trigger the event
    }

    // Event handler method
    static void Button_ClickHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Event Handler Executed: Button was clicked!");
    }
}

/*
🔹 Explanation:

event EventHandler Clicked; → Declares an event based on EventHandler.
Click() → Raises the event using Clicked?.Invoke(this, EventArgs.Empty);.
button.Clicked += Button_ClickHandler; → Subscribes the Button_ClickHandler method to the event.
When Click() is called, the event is triggered, and the subscribed handler executes.
 
*/

// Custom Event with Delegate

public class Alarm
{
    // Define delegate
    public delegate void AlarmEventHandler(string message);

    // Declare event
    public event AlarmEventHandler AlarmTriggered;

    public void TriggerAlarm()
    {
        if (AlarmTriggered != null)
        {
            AlarmTriggered("Warning! Alarm Activated!");
        }
    }
}

public class Program4
{
    static void Main()
    {
        Alarm alarm = new Alarm();
        alarm.AlarmTriggered += AlarmHandler; // Subscribe to event

        alarm.TriggerAlarm(); // Raise event
    }

    static void AlarmHandler(string message)
    {
        Console.WriteLine("Received Alert: " + message);
    }
}


/*
🔹 Best Practices for Events
✅ Use EventHandler and EventArgs instead of custom delegates when possible.
✅ Always check if an event has subscribers before invoking (?.Invoke()).
✅ Unsubscribe from events when no longer needed (-= handler).
✅ Avoid raising events in constructors to prevent incomplete object issues.

🔹 Real-World Use Cases
✔ Button Clicks in UI (WinForms, WPF)
✔ Data Change Notifications
✔ File System Changes (e.g., File Watchers)
✔ Multithreading and Asynchronous Programming (e.g., Task Completion Events) 
*/
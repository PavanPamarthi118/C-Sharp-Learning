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
An event is a wrapper around a delegate that provides controlled access to prevent direct method calls.

Why Use Events?

✔ Encapsulates delegates (prevents external modification).
✔ Follows event-driven programming model (e.g., button clicks).
✔ Used in GUI applications (WinForms, WPF, Blazor, etc.).*/


class Button
{
    //  Define a delegate for the event
    public delegate void ClickEventHandler();

    // Declare an event based on the delegate
    public event ClickEventHandler OnClick;

    // Method to simulate button click
    public void Click()
    {
        Console.WriteLine("Button clicked!");

        // Raise the event if there are subscribers
        OnClick?.Invoke();
    }
}

class Program3
{
    // Event handler (method that responds to the event)
    static void ShowMessage()
    {
        Console.WriteLine("Button was clicked! Performing action...");
    }

    static void Main()
    {
        Button btn = new Button();

        // Subscribe ShowMessage() to the OnClick event
        btn.OnClick += ShowMessage;

        // Simulate a button click
        btn.Click();
    }
}


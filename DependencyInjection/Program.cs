// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*Dependency Injection(DI) is a design pattern used in C# to manage dependencies between classes. 
    It helps achieve loose coupling by injecting dependencies instead of creating them inside a class.

Why Use Dependency Injection?

✅ Loose Coupling – Makes your code more maintainable and testable.
✅ Easier Testing – Allows injecting mock dependencies for unit testing.
✅ Improved Flexibility – You can change implementations without modifying dependent classes.*/


//Types of Dependency Injection

//1️ Constructor Injection(Most common)
//2️ Property Injection
//3️ Method Injection



//Without Dependency Injection (Tightly Coupled Code)

//class EmailService
//{
//    public void SendEmail(string message)
//    {
//        Console.WriteLine($"Email sent: {message}");
//    }
//}

//class OrderService //  with this approach is that our high level OrderService class is dependent on the lower level EmailService class which violate Dependency Inversion Principle(DIP) from SOLID
//{
//    private EmailService _emailService = new EmailService(); // Tightly coupled dependency

//    public void ProcessOrder()
//    {
//        Console.WriteLine("Order processed!");
//        _emailService.SendEmail("Your order has been shipped!");
//    }
//}

//class Program1
//{
//    static void Main()
//    {
//        OrderService orderService = new OrderService();
//        orderService.ProcessOrder();
//    }
//}

/*❌ Problems in the above approach:
Tightly coupled – OrderService is directly dependent on EmailService.
Hard to test – You can't easily replace EmailService with a mock version.
Difficult to extend – If you need to send an SMS instead, you'd have to modify OrderService.*/


//With Dependency Injection (Loosely Coupled Code)

// Define an Interface (Abstraction)

interface INotificationService
{
    void Send(string message);
}

// Implement the Interface
class EmailService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

class SMSService :INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}
// Inject the Dependency
class OrderService //Now our OrderService class is dependent on only the INotificationService interface, not a specific implementation of EmailService/SMSService
{
    private readonly INotificationService _notificationService;

    // Injecting dependency through the constructor
    public OrderService(INotificationService notificationService) // Dependency Injection
    {
        _notificationService = notificationService;
    }

    public void ProcessOrder()
    {
        Console.WriteLine("Order processed!");
        _notificationService.Send("Your order has been shipped!");
    }

    // Injecting dependency via property
    public INotificationService NotificationService { get; set; } 

    public void ProcessOrder1()
    {
        Console.WriteLine("Order processed!");
        NotificationService?.Send("Your order has been shipped!");
    }

    // Injecting dependency via Method 
    public void ProcessOrder2(INotificationService notificationService)
    {
        Console.WriteLine("Order processed!");
        notificationService.Send("Your order has been shipped!");
    }
}

// Configure DI in Main (Manually Inject Dependencies)
class Program
{
    static void Main()
    {
        INotificationService emailService = new EmailService();  // Create dependency
        OrderService orderService1 = new OrderService(emailService);  // Inject dependency

        //Can be writtedn as 
        //OrderService orderService1 = new OrderService(new EmailService());  // Create dependency & Inject dependency

        // Setting dependency via property
        //OrderService.NotificationService = new EmailService();
        //OrderService.ProcessOrder1();

        // Passing dependency as a method parameter
        //OrderService.ProcessOrder2(new EmailService());

        INotificationService SMSService = new SMSService();  // Create dependency
        OrderService orderService2 = new OrderService(SMSService);  // Inject dependency

        orderService1.ProcessOrder();
        orderService2.ProcessOrder();

        /*
        //Using Dependency Injection in ASP.NET Core
        //Most modern C# applications use a DI Container to handle dependencies automatically.


        // Step 1: Create a DI Container
        var serviceProvider = new ServiceCollection()
            .AddSingleton<INotificationService, EmailService>() // Register dependency
            .AddTransient<OrderService>() // Register OrderService
            .BuildServiceProvider();

        // Step 2: Resolve Dependencies
        var orderService = serviceProvider.GetService<OrderService>();
        orderService.ProcessOrder();

        //How This Works

        //AddSingleton<INotificationService, EmailService>() → Registers EmailService as an implementation of INotificationService.
        //AddTransient<OrderService>() → Creates a new instance of OrderService when requested.
        //serviceProvider.GetService<OrderService>() → Automatically injects dependencies.*/
    }
}
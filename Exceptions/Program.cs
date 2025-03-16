// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

try //The try statement allows you to define a block of code to be tested for errors while it is being executed.
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]);
}
catch (Exception e) //The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
{
    Console.WriteLine("Something went wrong.");
}
finally //The finally statement lets you execute code, after try...catch, regardless of the result:
{
    Console.WriteLine("The 'try catch' is finished.");
}
static void checkAge(int age)
{
    if (age < 18)
    {
        throw new ArithmeticException("Access denied - You must be at least 18 years old."); //The throw statement allows you to create a custom error.
    }
    else
    {
        Console.WriteLine("Access granted - You are old enough!");
    }
}

static void Main(string[] args)
{
    checkAge(15);
}

//The difference between throw; and throw ex; in C# is mainly in how they preserve the original stack trace of an exception

// throw; (Preserves Original Stack Trace ✅)

//Re - throws the same exception while keeping the original stack trace.
//Best practice when handling exceptions because it retains where the error actually happened.

//throw ex; (Resets Stack Trace ❌)

//Throws a new exception instance.
//Loses the original stack trace.
//Not recommended unless you need to wrap the exception in a custom message.
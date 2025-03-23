// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Generics in C# allow you to define classes, interfaces, and methods with a placeholder (type parameter). 
This enables code reusability while maintaining type safety. 

Why Use Generics?

✅ Type Safety → Prevents type mismatches at compile-time.
✅ Code Reusability → No need to write the same code for different data types.
✅ Performance → Avoids unnecessary boxing/unboxing (for value types).

*/

class Program
{
    // Generic Method
    static void Print<T>(T value)  // ✅ T is a placeholder for a data type that gets determined at runtime.
    {
        Console.WriteLine(value);
    }
    static void Main()
    {
        Print<int>(100);
        Print<string>("Pavan");
        Print<double>(523.3689);
    }
}

//Generic Class Example

class Box<T>  // Generic Class
{
    private T _value;

    public void SetValue(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}

class Program2
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();
        intBox.SetValue(10);
        Console.WriteLine(intBox.GetValue());  // Output: 10

        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Generics in C#");
        Console.WriteLine(stringBox.GetValue());  // Output: Generics in C#
    }
}
//✅ The Box<T> class works for any type, avoiding code duplication.
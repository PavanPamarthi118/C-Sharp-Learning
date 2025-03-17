// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//--------------------------------------------------  Tuples   ----------------------------------------------------------//

// Tuples allow you to return multiple values from a method without creating a class.

class Program1
{
    static (string name, int age) GetPersonalInfo()
    {
        return ("Pavan", 27);
    }
    static void Main()
    {
        var person = GetPersonalInfo();
        Console.WriteLine($"Name :{person.name}, Age:{person.age}");

    }
}


//--------------------------------------------------  LINQ   ----------------------------------------------------------//

//LINQ provides a clean way to query collections.

class Program2
{
    static void Main()
    {
        List<int> myList = new List<int> { 1, 2, 3, 5, 4, 4, 8, 5, 6, 4, 5 };
        var evenNumbers = myList.Where(n => n % 2 == 0).ToList();
        Console.WriteLine(string.Join(",", evenNumbers));
    }
}


//--------------------------------------------------  File Handling   ----------------------------------------------------------//

//C# provides File, StreamReader, and StreamWriter classes to read and write files.

class Program3
{
    static void Main()
    {
        if (File.Exists("data.txt"))
        {
            string content = File.ReadAllText("data.txt");
            Console.WriteLine($"File Content: {content}");

            File.WriteAllText("data.txt", "Hello, File Handling!");
            Console.WriteLine("File written successfully.");
        }

    }
}



//--------------------------------------------------  Attributes & Reflection   ----------------------------------------------------------//

// Attributes allow you to add metadata to classes, methods, and properties. Reflection allows you to read that metadata at runtime. 

[AttributeUsage(AttributeTargets.Class)]
class DeveloperInfo : Attribute
{
    public string Developer { get; }

    public DeveloperInfo(string developer)
    {
        Developer = developer;
    }
}

[DeveloperInfo("Alice")]
class SampleClass { }

class Program4
{
    static void Main()
    {
        var attributes = typeof(SampleClass).GetCustomAttributes(false);
        foreach (DeveloperInfo attr in attributes)
        {
            Console.WriteLine($"Developer: {attr.Developer}");
        }
    }
}




//--------------------------------------------------  Span<T> & Memory<T> (Performance Optimization)   ----------------------------------------------------------//Refer my Latest .NET9 Features PR

// Introduced in C# 7+, Span<T> and Memory<T> allow fast, memory-safe data access without allocations.

class Program5
{
    static void Main()
    {
        ReadOnlySpan<char> span = "Hello, World!".AsSpan();
        ReadOnlySpan<char> hello = span.Slice(0, 5);

        Console.WriteLine(hello.ToString()); // Output: Hello
    }
}

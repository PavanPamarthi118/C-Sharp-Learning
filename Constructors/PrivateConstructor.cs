class Singleton
{
    private static Singleton instance;

    // Private Constructor
    private Singleton()
    {
        Console.WriteLine("Private Constructor Called!");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

class Program1
{
    static void Main()
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();
    }
}

//Used when you want to restrict object creation.
//Useful for Singleton Design Pattern.

//Since the constructor is private, we cannot create objects using new. We can only get the instance using GetInstance(), which ensures only one object is created.

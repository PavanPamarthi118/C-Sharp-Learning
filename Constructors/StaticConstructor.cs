

namespace Constructors
{
    class StaticConstructor
    {
        // If your class is contains any static variable then implicit static constructors will present Other Wise We Must Define them explicitly
        static StaticConstructor() // Static Constructor defined explictly
        {
            Console.WriteLine("Static Constructor is executed"); //This executes first before Main

        }
        public StaticConstructor() // Implicit/ defalut Constructor
        {

        }
        static void Main()
        {
            Console.WriteLine("Main method is executed");
        }
    }
}

// Static Constructors are responsible in intializing static variables and these constructors are never called explictly, they are implicitly called
// Moereover these constructors are first to execute under any class and can't be parameterized

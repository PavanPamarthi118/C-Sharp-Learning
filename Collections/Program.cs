// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*A collection in C# is a data structure that holds multiple objects in a single unit. Unlike arrays, collections are dynamic, meaning they can grow or shrink at runtime.
 
Types of Collections in C#

1️ Non-Generic Collections (Old, less efficient)

Found in System.Collections namespace
Examples: ArrayList, Hashtable, Queue, Stack

2️ Generic Collections (Recommended)

Found in System.Collections.Generic namespace
Type-safe (stores a specific type)
Examples: List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>, HashSet<T>
*/

//--------------------------------------------- Non-Generic Collections ---------------------------------------//

// ArrayList (Dynamic Array) -------- > Similar to an array but dynamically resizable.

using System.Collections;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(1026);
        list.Add("Hello");
        list.Add('W');
        list.Add(20.35665);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

//Downside? Since it allows different types, it can cause type errors at runtime.

// Hashtable (Key-Value Pair) ----> Stores key-value pairs (unordered). -----> Keys & values can be of any type.


class Program2
{
    static void Main()
    {
        Hashtable table = new Hashtable();
        table.Add(1, "one");
        table.Add(2, "two");
        table.Add(3, "there");
        table.Add(4, "four");

        foreach (var item in table)
        {
            Console.WriteLine(item);
        }
    }
}

// Downside? No type safety, may cause runtime errors.


// Stack(LIFO - Last In, First Out) ----> Like a stack of plates, last added item is removed first. ------> Push() to add, Pop() to remove.


class Program3
{
    static void Main()
    {
        Stack mystack = new Stack();
        mystack.Push("A");
        mystack.Push("B");
        mystack.Push("C");
        mystack.Push("D");

        Console.WriteLine(mystack.Pop()); // Output: C (Last item removed first)
    }
}

// Queue(FIFO - First In, First Out)  ------------> Like a line in a bank, first element is removed first. ------> Enqueue() to add, Dequeue() to remove.

class Program4
{
    static void Main()
    {
        Queue myQueue = new Queue();

        myQueue.Enqueue("12");
        myQueue.Enqueue("2");
        myQueue.Enqueue("51");
        myQueue.Enqueue("15");

        Console.WriteLine(myQueue.Dequeue()); // Output: 12
    }
}

//---------------------------------------------- Generic Collections ------------------------------------------------//


// List<T> (Dynamic Array, Type-Safe) ---------> Recommended over ArrayList since it's type-safe.
class Program5
{
    static void Main()
    {
        List<int> mylist = new List<int>();
        mylist.Add(1);
        mylist.Add(6);
        mylist.Add(9);
        mylist.Add(14);

        foreach (var item in mylist)
        {
            Console.WriteLine(item);

        }
    }
}

// Safer and faster than ArrayList because it only allows int.

// Dictionary<TKey, TValue>(Key - Value Collection) ------------> Stores unique keys and their corresponding values. ------------> Keys must be unique.

class Program6
{
    static void Main()
    {
        Dictionary<int,String> mydic = new Dictionary<int, string>();
        mydic.Add(1, "One");
        mydic.Add(2, "Two");
        mydic.Add(3, "Three");

        Console.WriteLine(mydic[2]);  // Output: Two
    }
}

// ✅ Safer than Hashtable, as it enforces types.


//Stack<T> (Generic LIFO)
class Program7
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine(stack.Pop()); // Output: 30

    }
}


//Queue<T> (Generic FIFO)
class Program8
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine(queue.Dequeue()); // Output: First

    }
}


// HashSet<T> (Unique Collection) -------> Stores only unique values (no duplicates allowed)
class Program9
{
    static void Main()
    {
        HashSet<int> myHashSet = new HashSet<int>();
        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Add(3);
        myHashSet.Add(1);

        foreach (var item in myHashSet)
        {
            Console.WriteLine(item);
        }

    }
}
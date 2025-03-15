// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



/*--------------------- Value Types vs Reference Types --------------------- 
 * 
In C#, data types are categorized into Value Types and Reference Types, which define how they are stored in memory.

Value Types
Stored in the stack (fast memory).
Holds the actual data.
Copied by value when assigned or passed to a method.

Examples: int, float, double, char, bool, struct, enum


// Value Type
int a = 10;
int b = a; // Copies the value of 'a' to 'b'
b = 20;

Console.WriteLine(a); // Output: 10 (unchanged)
Console.WriteLine(b); // Output: 20


Reference Types
Stored in the heap (dynamic memory).
Holds a reference (memory address) to the actual object.
Copied by reference when assigned or passed to a method.
Examples: class, interface, string, object, array, delegate

//Reference Type*/

class Person
{
    public string name;

}
class Program
{
    static void Main()
    {
        Person person1 = new Person();
        person1.name = "Pavan";

        Person person2 = person1; // Copies the reference, NOT the value
        person2.name = "Boo";

        Console.WriteLine(person1.name); // Output: Bob (Both point to the same object)
        Console.WriteLine(person2.name); // Output: Bob 

        //Changing person2.Name also affects person1.Name because both person1 and person2 point to the same object in memory.

    }

}

//--------------------- Boxing ---------------------//

/*Boxing is the process of converting a value type (int, char, struct, etc.) into an object (reference type
Happens implicitly (automatically).
Moves data from the stack to the heap*/

int num1 = 10; // Value Type (stored in stack)
object obj = num1; // Boxing (moved to heap)

Console.WriteLine(obj); // Output: 10


//------------------Unboxing ---------------------//


/*Unboxing is the process of converting an object (reference type) back to a value type.

 Happens explicitly (manual cast required).
Moves data from the heap back to the stack.*/

object obj2 = 10; // Boxing (stored in heap)
int num2 = (int)obj2; // Unboxing (moved back to stack)

Console.WriteLine(num2); // Output: 10

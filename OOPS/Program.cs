// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 OOP stands for Object-Oriented Programming.

Procedural programming is about writing procedures or methods that perform operations on the data, 
while object-oriented programming is about creating objects that contain both data and methods.

Object-oriented programming has several advantages over procedural programming:

OOP is faster and easier to execute
OOP provides a clear structure for the programs
OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
OOP makes it possible to create full reusable applications with less code and shorter development time 
*/


//--------------------------Class------------------------------//


/* A class is a blueprint or template for creating objects.
🔹 It defines properties(data) and methods(behavior) but does not store actual data.
🔹 Example: A class Car defines properties like Brand, Model, and Color but does not represent a real car. */

//--------------------------object------------------------------//

//An object is an instance of a class.It holds actual data and interacts with methods. 


public class car
{
    // Fields (Attributes)
    public string model;
    public string brand;
    public string color;

    // Method (Behavior)
    public void Drive()
    {
        Console.WriteLine("I am driving " + brand + " " + model + " of color " + color);
    }
}
public class Program
{
    static void Main()
    {
        // Creating an object of Car
        car mycar = new car();
        mycar.brand = "Porsche";
        mycar.color = "Red";
        mycar.model = "911GT3 RS";

        // Calling a method on the object
        mycar.Drive();
    }
}



//  Fields vs. Properties 

//Example Fields  ----> public string name; ----> ✅ Use Fields if the variable is private and only used internally.
//Example Properties  ----> public string Name { get; set; } ----> ✅ Use Properties when exposing data outside the class (encapsulation, validation, computed values).

 
class Car
{
    private string brand;  // Private field

    // Public property to access the private field
    public string Brand
    {
        get { return brand; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                brand = value;
            else
                Console.WriteLine("Brand cannot be empty!");
        }
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Brand = "Tesla";  // Uses setter
        Console.WriteLine(car1.Brand);  // Uses getter

        car1.Brand = "";  // Shows "Brand cannot be empty!"
    }
}



//------------------------------------ Encapsulation – Hiding Data Using Properties ------------------------------------//

//Encapsulation means hiding the internal details of an object and only exposing necessary functionality through public methods or properties.
//🔹 It protects data from unauthorized access.
//🔹 Uses private fields and public properties (get/set methods).

class Person
{
    private string name;  // Private field (cannot be accessed directly)

    // Public property to get and set name safely
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty!");
        }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "John Doe";  // Using the property to set the value
        Console.WriteLine(p.Name);  // Output: John Doe

        p.Name = "";  // Invalid, will show "Name cannot be empty!"
    }
}


//------------------------------------ Abstraction – Hiding Complexity, Showing Only Essentials ------------------------------------//

//Abstraction means hiding complex implementation details and only exposing what is necessary.
//🔹 Uses abstract classes and interfaces.
//🔹 Helps in reducing complexity by exposing only essential features.


// Abstract class
abstract class Vehicle
{
    public abstract void Start();  // Abstract method (no implementation)
}

// child class
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car starts with a key.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        myCar.Start();  // Output: Car starts with a key.
    }
}


//------------------------------------ Inheritance – Reusing Code from Parent Classes ------------------------------------//

//Inheritance allows a class to reuse methods and properties from another class.
//🔹 The child class inherits from the parent class.
//🔹 Promotes code reusability and reduces redundancy.



// Parent class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

// Child class inheriting Animal class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Eat();  // Output: This animal eats food. (Inherited)
        myDog.Bark(); // Output: The dog barks.
    }
}



//------------------------------------ Polymorphism – Same Method, Different Behavior ------------------------------------//

//Polymorphism means one method behaves differently based on the object calling it.
//🔹 Achieved using Method Overloading (Compile - Time) and Method Overriding (Runtime).
//🔹 Helps in flexibility and scalability.



class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Cat();
        myAnimal.MakeSound();  // Output: Cat meows. (Overridden method)
    }
}


// --------------------- Method Overloading (Same Class, Different Parameters) -----------------------//

//Method Overloading allows multiple methods with the same name but different parameter lists.


class MathOperations
{
    // Method 1: Adds two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: Adds three integers (Overloaded)
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method 3: Adds two doubles (Overloaded)
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();

        Console.WriteLine(math.Add(2, 3));         // Output: 5
        Console.WriteLine(math.Add(2, 3, 4));      // Output: 9
        Console.WriteLine(math.Add(2.5, 3.5));     // Output: 6.0
    }
}


//---------------------- Method Overriding (Parent-Child Relationship) -------------------------//

//Method Overriding allows a child class to provide a new implementation for a method already defined in a parent class.


// Parent class
class Animal
{
    public virtual void MakeSound()  // "virtual" allows method overriding
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived class
class Dog : Animal
{
    public override void MakeSound()  // "override" modifies the parent method
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        myAnimal.MakeSound();  // Output: Animal makes a sound.

        Dog myDog = new Dog();
        myDog.MakeSound();  // Output: Dog barks.

        // Polymorphism: Base class reference, derived class object
        Animal myPet = new Dog();
        myPet.MakeSound();  // Output: Dog barks. (Dynamic Polymorphism)
    }
}


//----------------------------------------------- 🚀 Real-World Example: OOP in a Banking System  -----------------------------------------------------//


abstract class Account
{
    public string AccountNumber { get; set; }
    public double Balance { get; protected set; }

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
}

 //Inheritance & Polymorphism
class SavingsAccount : Account
{
    public override void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
    }

    public override void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. Remaining Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }
}

class Program
{
    static void Main()
    {
        Account myAccount = new SavingsAccount();
        myAccount.Deposit(1000);
        myAccount.Withdraw(500);
    }
}


/* ✔ Encapsulation – Balance is protected (private property).
✔ Abstraction – Account defines Deposit() and Withdraw(), hiding internal banking logic.
✔ Inheritance – SavingsAccount inherits from Account.
✔ Polymorphism – Withdraw() and Deposit() behave differently for different account types.
*/
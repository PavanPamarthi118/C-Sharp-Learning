// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//------------------------------------Constructor--------------------------------------// (https://www.youtube.com/watch?v=Fo_SED11gME)

//It's a special method present under a class responsible for initializing the variab;es of that class
//The name of a constructor is exactly same as the name of the class in which that constructor is present
//A constructor does not have a return type (not even void).
class Person
{
    public int number;
    public string name;
    public bool b;

    // Initializing the variables (implicit constaructor / defalut constructor) - compliler will define it not us, [Method name is same as class name]
    // implicit constaructor are parameterless constructors and they are public
    public Person() //Explicit 
    {
        number = 0;
        name = "";
        b = false;
    }
    // if we defined it's called explicit constructor(can be parameterless or parameterized )

    static void Main()
    {
        Person p1 = new Person(); //Everytime the instance of a class is created, the constaructor is called
        Person p2 = new Person();
        Person p3 = new Person();

        Console.WriteLine(p1.name);
        Console.WriteLine(p1.number);
        Console.WriteLine(p2.b);

    }

}

//Constructor Type                                                               	
//1. Default Constructor -------------------->	A constructor with no parameters.
//2. Parameterized Constructor -------------------->  A constructor that takes parameters to initialize values.
//3. Copy Constructor -------------------->  A constructor that creates a copy of another object.
//4. Static Constructor	-------------------->  A constructor that initializes static members and runs only once per class.
//5. Private Constructor --------------------> A constructor that prevents object instantiation from outside the class.
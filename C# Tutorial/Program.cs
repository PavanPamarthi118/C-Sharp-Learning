//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/* ------------------- Basics --------------------*/

public class HelloWorld
{
    static void Main(string[] args)
    {
        //Console.WriteLine("hello worlds!");

        //const double pi = 3.14159; //The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code
        //pi = 84;

        //Implicit Casting (automatically) - converting a smaller type to a larger type size

        int myNum = 256;
        double myDOuble = myNum;

        //Explicit Casting (manually) - converting a larger type to a smaller size type

        double myDouble = 235.65;
        int myInt = (int)myDouble;

        //We can also use Convert.To...... built in methods

        //User Input

        //Console.WriteLine("Enter you Name");
        //string userName = Console.ReadLine();
        //Console.WriteLine("User name is " +userName);

        string firstName = "Pavan Pavan";
        string lastName = "Pamarthi";

        string fullName1 = firstName + lastName;

        //Concat
        string fullName2 = string.Concat(firstName, lastName);

        //String Interpolation
        string fullName3 = $"My full Name is : {firstName}{lastName}";

        //Access Strings
        //Console.WriteLine(firstName[9]);

        //Find the index position of a specific character in a string
        //Console.WriteLine(firstName.IndexOf("v"));

        //Substrings, which extracts the characters from a string

        string lastNameSub = lastName.Substring(0, 5);
        //Console.WriteLine(lastNameSub);

        //Switch case

        //switch(Expression)
        //{
        //    case x:
        //        code for x;
        //            break;

        //    case y:
        //       code for y;
        //              break;

        //    defalut case:
        //        default code;
        //        break;
        //}

        // Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value

        string[] cars = { "BMW", "Porsche", "Ferrari", "Meclerin", "Audi", "Volvo" }; //Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

        //A multidimensional array is basically an array of arrays.

        int[,] myNumbers = { { 5, 6, 9, 8 }, { 2, 9, 6, 9 } };
        // The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].

        //---------------------Methods-----------------------//

        //A method is a block of code which only runs when it is called.
        //You can pass data, known as parameters, into a method.
        //Methods are used to perform certain actions, and they are also known as functions.
        //Why use methods? To reuse code: define the code once, and use it many times. 

        //    class program
        //{
        //    static void myMethod()
        //    {
        // code to be executed
        //    }
        //}

        string fullName5 = GetMyName(lastName, firstName);
        string fullName6 = GetMyName(lastName);
        Console.WriteLine(fullName5);
        Console.WriteLine(fullName6);

        int number1 = 52;
        int number2 = 95;
        double numberwithdecimal1 = 5.632;
        double numberwithdecimal2 = 95.632;

        int tottal = getmyNumbers(number1, number2);
        double tottaldecimal = getmyNumbers(numberwithdecimal1, numberwithdecimal2);



        ParentAnimal myanimal = new ParentAnimal();
        myanimal.GetAnimalSound();

        ChildDog myChildAnimal = new ChildDog();
        myChildAnimal.GetAnimalSound();

    }
    public static string GetMyName( string lastName, string firstName = "Pavan") //Optional Parameters
                                                                                 //✅ Must be declared at the end of the parameter list.
                                                                                 //✅ Cannot be used in the middle of required parameters.
                                                                                 //✅ Can have multiple optional parameters, but they must come after required parameters.
    {
        return   firstName + lastName;
    }

    //Method Overloading
    //With method overloading, multiple methods can have the same name with different parameters
    static int getmyNumbers(int num1,int num2)
    {
        return num1 + num2;
    }
    static double getmyNumbers(double num1, double num2)
    {
        return num1 + num2;
    }

    //Method Overriding (Parent-Child Relationship)
    //Method Overriding allows a child class to provide a new implementation for a method already defined in a parent class.
    class ParentAnimal
    {
        public virtual void GetAnimalSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    class ChildDog : ParentAnimal
    {
        public override void GetAnimalSound()
        {
            Console.WriteLine("Dog Makes Sound");
        }
    }

}
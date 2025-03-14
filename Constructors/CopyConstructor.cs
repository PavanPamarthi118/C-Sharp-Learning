class Car
{
    public string Brand;
    public int Speed;

    // Parameterized Constructor
    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    // Copy Constructor
    public Car(Car obj)
    {
        Brand = obj.Brand;
        Speed = obj.Speed;
    }

    public void Display()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Audi", 180);
        Car car2 = new Car(car1); // Copying car1 values into car2

        car1.Display();
        car2.Display();
    }
}

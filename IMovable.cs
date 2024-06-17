// Interface
public interface IMovable
{
    void Move();
}

// Class Car implementing IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class Bicycle implementing IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();      // Outputs: Car is moving
        bicycle.Move();  // Outputs: Bicycle is moving
    }
}
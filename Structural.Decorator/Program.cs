using System;

// Component
interface ICar
{
    void Assemble();
}

// ConcreteComponent
class BasicCar : ICar
{
    public void Assemble()
    {
        Console.WriteLine("Basic Car. ");
    }
}

// Decorator
abstract class CarDecorator : ICar
{
    protected ICar car;

    public CarDecorator(ICar car)
    {
        this.car = car;
    }

    public virtual void Assemble()
    {
        car.Assemble();
    }
}

// ConcreteDecorator
class SportsCar : CarDecorator
{
    public SportsCar(ICar car) : base(car)
    {
    }

    public override void Assemble()
    {
        base.Assemble();
        Console.WriteLine("Adding features of Sports Car. ");
    }
}

// ConcreteDecorator
class LuxuryCar : CarDecorator
{
    public LuxuryCar(ICar car) : base(car)
    {
    }

    public override void Assemble()
    {
        base.Assemble();
        Console.WriteLine("Adding features of Luxury Car. ");
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        ICar basicCar = new BasicCar();
        basicCar.Assemble();

        ICar sportsCar = new SportsCar(basicCar);
        sportsCar.Assemble();

        ICar luxuryCar = new LuxuryCar(basicCar);
        luxuryCar.Assemble();

        ICar sportsLuxuryCar = new LuxuryCar(new SportsCar(basicCar));
        sportsLuxuryCar.Assemble();
    }
}
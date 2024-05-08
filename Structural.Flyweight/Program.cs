using System;
using System.Collections.Generic;

// Flyweight
abstract class Flyweight
{
    public abstract void Operation(int extrinsicState);
}

// ConcreteFlyweight
class ConcreteFlyweight : Flyweight
{
    private string intrinsicState;

    public ConcreteFlyweight(string intrinsicState)
    {
        this.intrinsicState = intrinsicState;
    }

    public override void Operation(int extrinsicState)
    {
        Console.WriteLine("ConcreteFlyweight: Intrinsic State = " + intrinsicState + ", Extrinsic State = " + extrinsicState);
    }
}

// FlyweightFactory
class FlyweightFactory
{
    private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

    public Flyweight GetFlyweight(string key)
    {
        if (flyweights.ContainsKey(key))
        {
            return flyweights[key];
        }
        else
        {
            Flyweight flyweight = new ConcreteFlyweight(key);
            flyweights.Add(key, flyweight);
            return flyweight;
        }
    }
}

// Client
class Client
{
    private FlyweightFactory flyweightFactory;

    public Client(FlyweightFactory flyweightFactory)
    {
        this.flyweightFactory = flyweightFactory;
    }

    public void Operation(string key, int extrinsicState)
    {
        Flyweight flyweight = flyweightFactory.GetFlyweight(key);
        flyweight.Operation(extrinsicState);
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        FlyweightFactory flyweightFactory = new FlyweightFactory();
        Client client1 = new Client(flyweightFactory);
        client1.Operation("FlyweightA", 100);

        Client client2 = new Client(flyweightFactory);
        client2.Operation("FlyweightB", 200);

        Client client3 = new Client(flyweightFactory);
        client3.Operation("FlyweightA", 300);
    }
}
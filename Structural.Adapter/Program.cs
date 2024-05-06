interface ITarget
{
    string Request(int i);
}

class Adaptee
{
    public double SpecificRequets(double a, double b)
    {
        return a / b;
    }
}

//Adapter giữa hai giao diện
class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }
    public string Request(int i)
    {
        return $"Result: {_adaptee.SpecificRequets(i,5)}";
    }
}

class Client
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);
        Console.WriteLine(target.Request(110));
    }
}
public interface IVisitor
{
    void VisitConcreteElementA(ConcreteElementA elementA);
    void VisitConcreteElementB(ConcreteElementB elementB);
}

public class ConcreteVisitor : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA elementA)
    {
        Console.WriteLine($"ConcreteVisitor: Visiting {elementA.GetType().Name}");
    }

    public void VisitConcreteElementB(ConcreteElementB elementB)
    {
        Console.WriteLine($"ConcreteVisitor: Visiting {elementB.GetType().Name}");
    }
}
public interface IElement
{
    void Accept(IVisitor visitor);
}
public class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }

    public void OperationA()
    {
        Console.WriteLine("ConcreteElementA: OperationA");
    }
}

public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }

    public void OperationB()
    {
        Console.WriteLine("ConcreteElementB: OperationB");
    }
}
public class ObjectStructure
{
    private List<IElement> _elements = new List<IElement>();

    public void Attach(IElement element)
    {
        _elements.Add(element);
    }

    public void Detach(IElement element)
    {
        _elements.Remove(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ObjectStructure objectStructure = new ObjectStructure();

        objectStructure.Attach(new ConcreteElementA());
        objectStructure.Attach(new ConcreteElementB());

        ConcreteVisitor visitor = new ConcreteVisitor();

        objectStructure.Accept(visitor);
    }
}

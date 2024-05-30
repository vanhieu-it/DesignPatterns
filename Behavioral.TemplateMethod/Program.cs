public abstract class AbstractClass
{
    // Template method
    public void TemplateMethod()
    {
        BaseOperation();
        RequiredOperation1();
        RequiredOperation2();
        Hook();
    }

    // Các bước đã triển khai
    protected void BaseOperation()
    {
        Console.WriteLine("AbstractClass: BaseOperation");
    }

    // Các bước yêu cầu lớp con triển khai
    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();

    // Hook (móc nối) - tùy chọn cho lớp con
    protected virtual void Hook() { }
}
public class ConcreteClass1 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass1: RequiredOperation1");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass1: RequiredOperation2");
    }

    protected override void Hook()
    {
        Console.WriteLine("ConcreteClass1: Hook");
    }
}

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass2: RequiredOperation1");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass2: RequiredOperation2");
    }
}
class Program
{
    static void Main(string[] args)
    {
        AbstractClass concreteClass1 = new ConcreteClass1();
        concreteClass1.TemplateMethod();

        Console.WriteLine();

        AbstractClass concreteClass2 = new ConcreteClass2();
        concreteClass2.TemplateMethod();
    }
}

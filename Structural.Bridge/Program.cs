using System;

// Interface for the implementation
public interface IShape
{
    void Draw();
}

// Concrete implementation classes
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

// Abstraction class
public abstract class Drawing
{
    protected IShape shape;

    protected Drawing(IShape shape)
    {
        this.shape = shape;
    }

    public abstract void DrawShape();
}

// Refined Abstraction classes
public class DrawingAPI1 : Drawing
{
    public DrawingAPI1(IShape shape) : base(shape)
    {
    }

    public override void DrawShape()
    {
        Console.WriteLine("Using API1 to draw...");
        shape.Draw();
    }
}

public class DrawingAPI2 : Drawing
{
    public DrawingAPI2(IShape shape) : base(shape)
    {
    }

    public override void DrawShape()
    {
        Console.WriteLine("Using API2 to draw...");
        shape.Draw();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle();
        IShape square = new Square();

        Drawing drawing1 = new DrawingAPI1(circle);
        drawing1.DrawShape();

        Drawing drawing2 = new DrawingAPI2(square);
        drawing2.DrawShape();
    }
}

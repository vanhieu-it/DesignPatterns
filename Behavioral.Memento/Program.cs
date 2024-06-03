public class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}
public class Originator
{
    public string State { get; set; }

    public Memento CreateMemento()
    {
        return new Memento(State);
    }

    public void RestoreMemento(Memento memento)
    {
        State = memento.State;
    }
}
public class Caretaker
{
    private readonly List<Memento> _mementos = new List<Memento>();
    private Originator _originator;

    public Caretaker(Originator originator)
    {
        _originator = originator;
    }

    public void SaveState()
    {
        Console.WriteLine("Saving state...");
        _mementos.Add(_originator.CreateMemento());
    }

    public void Undo()
    {
        if (_mementos.Count > 0)
        {
            var memento = _mementos.Last();
            _mementos.Remove(memento);
            Console.WriteLine("Restoring state...");
            _originator.RestoreMemento(memento);
        }
        else
        {
            Console.WriteLine("No states to restore.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker(originator);

        originator.State = "State1";
        caretaker.SaveState();

        originator.State = "State2";
        caretaker.SaveState();

        originator.State = "State3";
        caretaker.SaveState();

        Console.WriteLine($"Current State: {originator.State}");
        caretaker.Undo();
        Console.WriteLine($"Restored State: {originator.State}");
        caretaker.Undo();
        Console.WriteLine($"Restored State: {originator.State}");
        caretaker.Undo();
        Console.WriteLine($"Restored State: {originator.State}");
    }
}

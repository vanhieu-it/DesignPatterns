public interface IState
{
    void Handle(Context context);
}
public class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("State A is handling the context.");
        context.State = new ConcreteStateB();
    }
}

public class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("State B is handling the context.");
        context.State = new ConcreteStateA();
    }
}
public class Context
{
    private IState _state;

    public Context(IState state)
    {
        State = state;
    }

    public IState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"State has changed to {value.GetType().Name}");
        }
    }

    public void Request()
    {
        _state.Handle(this);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Context khởi đầu với trạng thái ConcreteStateA
        Context context = new Context(new ConcreteStateA());

        // Yêu cầu đầu tiên sẽ được xử lý bởi ConcreteStateA và chuyển trạng thái sang ConcreteStateB
        context.Request();

        // Yêu cầu thứ hai sẽ được xử lý bởi ConcreteStateB và chuyển trạng thái quay lại ConcreteStateA
        context.Request();
    }
}

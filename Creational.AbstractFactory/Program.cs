var oracleDatabaseFactory = new OracleDatabaseFactory();
var connection = oracleDatabaseFactory.CreateConnection();
var command = oracleDatabaseFactory.CreateCommand(connection);

connection.Connect();
command.Execute();
connection.DidConnect();

interface ICommand
{
    void Execute();
}
interface IConnection
{
    void Connect();
    void DidConnect();
}
interface IDatabaseFactory
{
    IConnection CreateConnection();
    ICommand CreateCommand(IConnection connection);
}

class OracleCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Oracle running...");
        Console.WriteLine("Complete");
    }
}
class OracleConnection : IConnection
{
    public void Connect()
    {
        Console.WriteLine("Connected");
    }

    public void DidConnect()
    {
        Console.WriteLine("Disconnected");
    }
}
class OracleDatabaseFactory : IDatabaseFactory
{
    public ICommand CreateCommand(IConnection connection)
        => connection == null ? throw new NullReferenceException() : new OracleCommand();

    public IConnection CreateConnection() => new OracleConnection();
}





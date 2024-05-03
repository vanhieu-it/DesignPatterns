String connectionString = new ConnectionBuilder()
    .SetDatabase("mysql")
    .SetServer("127.0.0.1")
    .SetUserId("sa")
    .SetPassword("123")
    .Build();

Console.WriteLine(connectionString);

class ConnectionBuilder
{
    private class Connection
    {
        public string? database;
        public string? server;
        public string? userId;
        public string? password;

        public override string ToString()
        {
            return $"Server={server};\nDatabase={database};\nUserId={userId};\nPassword={password}";
        }
    }

    private readonly Connection connection;
    public ConnectionBuilder()
    {
        connection = new Connection();
    }
    public ConnectionBuilder SetDatabase(String database)
    {
        connection.database = database;
        return this;
    }
    public ConnectionBuilder SetServer(String server)
    {
        connection.server = server;
        return this;
    }
    public ConnectionBuilder SetUserId(String userId)
    {
        connection.userId = userId;
        return this;
    }
    public ConnectionBuilder SetPassword(String password) {  
        connection.password = password;
        return this;
    }
    public String Build()
    {
        return connection.ToString();
    }
}
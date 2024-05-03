DateTimeSnapshot instance = Singleton.GetInstance();

Console.WriteLine(instance.GetDateTime());
Thread.Sleep(1000);
Console.WriteLine(instance.GetDateTime());
Thread.Sleep(1000);
Console.WriteLine(instance.GetDateTime());
Thread.Sleep(1000);
Console.WriteLine(instance.GetDateTime());
Thread.Sleep(1000);
Console.WriteLine(instance.GetDateTime());

class DateTimeSnapshot
{
    public string GetDateTime()
    {
        return DateTime.Now.ToString();
    }
}
class Singleton
{
    private static DateTimeSnapshot instance = new DateTimeSnapshot();
    public static DateTimeSnapshot GetInstance()
    {
        return instance;
    }
}



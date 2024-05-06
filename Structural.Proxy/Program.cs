public interface IImage
{
    void Display();
}
public class RealImage : IImage
{
    private string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        LoadFromDisk();
    }
    private void LoadFromDisk()
    {
       Console.WriteLine("Loading " + _filename);  
    }
    public void Display()
    {
        Console.WriteLine("Display " + _filename);
    }
}

public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _filename;
    public ProxyImage(string filename)
    {
        _filename = filename;
    }
    public void Display()
    {
        if( _realImage == null)
        {
            _realImage = new RealImage(_filename);
        }
        _realImage.Display();
    }
}
class Program
{
    static void Main(string[] args)
    {
        IImage image = new ProxyImage("test.png");
        image.Display();
        Console.WriteLine("");
        //Image sẽ không load từ disk
        image.Display();
    }
}
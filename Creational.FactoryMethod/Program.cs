IScreen screen = CreatorFactory.ScreenCreator(ScreenType.Windows);
screen.Draw();
IScreen screen1 = CreatorFactory.ScreenCreator(ScreenType.Web);
screen1.Draw();

interface IScreen
{
    void Draw();
}

enum ScreenType
{
    Windows,
    Web
}
class WebScreen : IScreen
{
    public void Draw()
    {
        Console.WriteLine("Drawing in web");
    }
}
class WindowScreen : IScreen
{
    public void Draw()
    {
        Console.WriteLine("Drawing in windows");
    }
}
static class CreatorFactory
{
    public static IScreen ScreenCreator(ScreenType screenType) => screenType switch
    {
        ScreenType.Web => new WebScreen(),
        ScreenType.Windows => new WindowScreen(),
        _=> throw new AggregateException()
    };
}
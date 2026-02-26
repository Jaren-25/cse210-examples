public class Button
{
    protected int _width;
    protected int _height;

    public Button(int width, int height)
    {
        Console.WriteLine("Button constructor");
        _width = width;
        _height = height;
    }

    public int GetWidth()
    {
        return _width;
    }

    public bool Click()
    {
        Console.WriteLine("Button Click");
        return true;
    }
}


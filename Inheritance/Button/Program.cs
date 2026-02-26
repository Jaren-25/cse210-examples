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

public class TextButton : Button
{
    private string _text;

    public TextButton(int width, int height, string text) : base(width, height)
    {
        Console.WriteLine("TextButton constructor");
        _text = text;
    }
}

public class ImageButton : Button
{
    private byte[,] _image;

    public ImageButton(int width, int height, byte[,] image) : base(width, height)
    {
        Console.WriteLine("ImageButton constructor");
        _image = image;

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Button genericButton = new Button(50, 10);

        TextButton txtButton = new TextButton(50, 10, "Click me!");

        ImageButton imgButton = new ImageButton(50, 10, null);
        imgButton.Click();
    }
}

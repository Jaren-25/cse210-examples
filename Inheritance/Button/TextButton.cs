public class TextButton : Button
{
    private string _text;

    public TextButton(int width, int height, string text) : base(width, height)
    {
        Console.WriteLine("TextButton constructor");
        _text = text;
    }
}


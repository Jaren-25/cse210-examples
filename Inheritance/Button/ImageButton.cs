
public class ImageButton : Button
{
    private byte[,] _image;

    public ImageButton(int width, int height, byte[,] image) : base(width, height)
    {
        Console.WriteLine("ImageButton constructor");
        _image = image;

    }
}


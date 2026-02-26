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

using System;

public class DancingCat : WurlitzerComponent
{
    private string _outfit = "Tuxedo";

    public DancingCat(string name) : base(name)
    {
    }

    public string GetOutfit()
    {
        return _outfit;
    }

    public void SetOutfit(string outfit)
    {
        _outfit = outfit;
    }

    public override void Perform()
    {
        if (IsOn())
        {
            Console.WriteLine($"{GetName()} (Dancing Cat) - 🐱 MEOW: The cat in the {_outfit} starts spinning and waving!");
        }
    }
}

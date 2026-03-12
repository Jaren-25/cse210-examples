using System;

public class DancingCat : Instrument
{
    private string _outfit = "Tuxedo";

    public DancingCat(string name):base(name)
    {
        _name = name;

    }

    public string GetOutfit()
    {
        return _outfit;
    }

    public void SetOutfit(string outfit)
    {
        _outfit = outfit;
    }



    public void BeginDance()
    {
        if (_isOn)
        {
            Console.WriteLine($"{_name} (Dancing Cat) - 🐱 MEOW: The cat in the {_outfit} starts spinning and waving!");
        }
    }
}

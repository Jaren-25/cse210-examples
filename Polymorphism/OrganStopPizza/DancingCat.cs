using System;

public class DancingCat 
{
    private string _outfit = "Tuxedo";
    private string _name;
    private bool _isOn;

    public DancingCat(string name)
    {
        _name = name;
        _isOn = false;
    }

    public string GetOutfit()
    {
        return _outfit;
    }

    public void SetOutfit(string outfit)
    {
        _outfit = outfit;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsOn()
    {
        return _isOn;
    }

    public void SetIsOn(bool isOn)
    {
        _isOn = isOn;
    }

    public void BeginDance()
    {
        if (_isOn)
        {
            Console.WriteLine($"{_name} (Dancing Cat) - 🐱 MEOW: The cat in the {_outfit} starts spinning and waving!");
        }
    }
}

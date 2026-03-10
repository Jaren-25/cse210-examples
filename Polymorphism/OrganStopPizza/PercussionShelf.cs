using System;

public class PercussionShelf 
{
    private string _instrumentName;
    private string _name;
    private bool _isOn;

    public PercussionShelf(string name)
    {
        _name = name;
        _isOn = false;
    }

    public string GetInstrumentName()
    {
        return _instrumentName;
    }

    public void SetInstrumentName(string instrumentName)
    {
        _instrumentName = instrumentName;
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

    public void Strike()
    {
        if (_isOn)
        {
            Console.WriteLine($"{_name} (Percussion) - 🥁 WHACK! The {_instrumentName} was hit!");
        }
    }
}

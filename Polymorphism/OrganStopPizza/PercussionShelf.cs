using System;

public class PercussionShelf : Instrument
{
    private string _instrumentName;


    public PercussionShelf(string name):base(name)
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


    public void Strike()
    {
        if (_isOn)
        {
            Console.WriteLine($"{_name} (Percussion) - 🥁 WHACK! The {_instrumentName} was hit!");
        }
    }
}

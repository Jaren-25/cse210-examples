using System;

public class PercussionShelf : WurlitzerComponent
{
    private string _instrumentName;

    public PercussionShelf(string name) : base(name)
    {
    }

    public string GetInstrumentName()
    {
        return _instrumentName;
    }

    public void SetInstrumentName(string instrumentName)
    {
        _instrumentName = instrumentName;
    }

    public override void Perform()
    {
        if (IsOn())
        {
            Console.WriteLine($"{GetName()} (Percussion) - 🥁 WHACK! The {_instrumentName} was hit!");
        }
    }
}

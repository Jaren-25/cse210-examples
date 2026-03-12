using System;

public class PipeOrgan : Instrument
{
    private string _note;


    public PipeOrgan(string name) : base(name)
    {
        _name = name;
        _isOn = false;
    }

    public string GetNote()
    {
        return _note;
    }

    public void SetNote(string note)
    {
        _note = note;
    }

    public void OpenValve()
    {
        if (_isOn)
        {
            Console.WriteLine($"{_name} (Pipe Organ) - 💨 Air rushing through pipe for note: {_note}");
        }
    }
}

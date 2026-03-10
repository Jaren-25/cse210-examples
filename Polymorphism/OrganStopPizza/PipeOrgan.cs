using System;

public class PipeOrgan 
{
    private string _note;
    private string _name;
    private bool _isOn;

    public PipeOrgan(string name)
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

    public void OpenValve()
    {
        if (_isOn)
        {
            Console.WriteLine($"{_name} (Pipe Organ) - 💨 Air rushing through pipe for note: {_note}");
        }
    }
}

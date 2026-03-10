using System;

public class PipeOrgan : WurlitzerComponent
{
    private string _note;

    public PipeOrgan(string name) : base(name)
    {
    }

    public string GetNote()
    {
        return _note;
    }

    public void SetNote(string note)
    {
        _note = note;
    }

    public override void Perform()
    {
        if (IsOn())
        {
            Console.WriteLine($"{GetName()} (Pipe Organ) - 💨 Air rushing through pipe for note: {_note}");
        }
    }
}

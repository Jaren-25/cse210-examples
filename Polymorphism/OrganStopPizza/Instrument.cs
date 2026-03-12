public class Instrument
{
    protected string _name;
    protected bool _isOn;

    public Instrument(string name)
    {
        _name = name;

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

}
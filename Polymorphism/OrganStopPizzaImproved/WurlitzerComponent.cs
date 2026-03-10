using System;

public abstract class WurlitzerComponent
{
    private string _name;
    private bool _isOn;

    public WurlitzerComponent(string name)
    {
        _name = name;
        _isOn = false;
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

    public abstract void Perform();
}
